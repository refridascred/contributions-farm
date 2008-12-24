using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long offset)
        {
            if (((double)target > (double)28) && ((double)target <= (2.6 - 9.85)))
            {
                return 2;
            }
            else
            {
                if ((target & 127) < (offset - target))
                {
                    return 4;
                }
                else
                {
                    if ((target + offset) < (offset - 359))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(target > offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
