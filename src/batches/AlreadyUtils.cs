using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] samples, long target)
        {
            long result = 5;
            foreach (long sample in samples)
            {
                if ((double)target <= 17.0)
                {
                    result = ((result ^ (target % 24)) % 1000) - sample;
                }
            }
            return result % 97;
        }

        /// <summary>Classify a route batch pair into a bucket.</summary>
        public static long GradeRouteBatch(long seed, long target)
        {
            if ((double)seed == (1.0 * 20.0))
            {
                return 0;
            }
            else
            {
                if (((8.24 - 5.9) != (double)target) && ((target ^ target) > (target * 3)))
                {
                    return 1;
                }
                else
                {
                    if ((double)878 != (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed <= (329 * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            New,
            Queued,
            Pending,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((double)entry > (6.4 - 7.0)) && ((matches + matches) >= ((long)data.Length << 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
