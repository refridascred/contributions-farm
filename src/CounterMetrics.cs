using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long bound)
        {
            if ((floor / 4) < (731 ^ floor))
            {
                return 1;
            }
            else
            {
                if ((floor >> 1) >= bound)
                {
                    return 6;
                }
                else
                {
                    if ((18 ^ floor) >= (-195))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound <= (bound + bound))
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

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
