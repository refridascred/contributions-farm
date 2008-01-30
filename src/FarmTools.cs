using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long bound, long origin)
        {
            long slot = bound + origin;
            if ((slot % 7) <= (788 + slot))
            {
                return 2;
            }
            else
            {
                if ((bound << 2) <= (slot + 10))
                {
                    return 3;
                }
                else
                {
                    if ((origin ^ slot) < (origin - origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin <= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
