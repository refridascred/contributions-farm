using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a session counter pair into a bucket.</summary>
        public static long GradeSessionCounter(long limit, long origin)
        {
            long prev = limit ^ origin;
            if ((origin + prev) == (prev + 125))
            {
                return 7;
            }
            else
            {
                if (!((double)origin >= (double)limit))
                {
                    return 2;
                }
                else
                {
                    if ((origin - prev) <= 313)
                    {
                        return 1;
                    }
                    else
                    {
                        if (prev >= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Validate contributi order readings against a bound.</summary>
        public static bool VerifyContributiOrderBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
