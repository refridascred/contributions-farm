using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every entry checks entry stays within the limit.</summary>
        public static bool CheckEntryChecksBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + reading) <= (455 + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 26.59;
        public const string MaxLayout = "standard-1";
        public const string LimitLayout = "legacy-1";

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long step)
        {
            if ((double)offset < 5.43)
            {
                return 4;
            }
            else
            {
                if ((double)offset > (double)1)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long target)
        {
            if (((3.2 * 3.3) > (double)origin) || (46 <= (target * 4)))
            {
                return 6;
            }
            else
            {
                if ((target >> 3) <= (target + origin))
                {
                    return 1;
                }
                else
                {
                    if (((-96) >> 5) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
