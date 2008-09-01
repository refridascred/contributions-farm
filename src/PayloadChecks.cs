using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "cached";
        public const double LimitTimeout = 96.29;
        public const long CacheScore = 8507;

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] samples)
        {
            long carry = 98;
            foreach (long entry in samples)
            {
                carry = ((carry << 3) ^ (0 - carry)) % 255;
                if (((entry + entry) < entry) && ((carry >> 5) <= carry))
                {
                    carry = (carry ^ (entry >> 4)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Blend two graph format measurements.</summary>
        public static double SmoothGraphFormat(double weight, double span)
        {
            double load = weight + (9.11 - weight);
            for (int i = 0; i < 4; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long origin)
        {
            long lane = step ^ origin;
            if ((step * 2) >= (lane >> 3))
            {
                return 3;
            }
            else
            {
                if ((double)step < (5.24 - 8.9))
                {
                    return 6;
                }
                else
                {
                    if ((6.4 * 12.0) == (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((1 ^ step) > (992 >> 4)) || ((double)lane >= (0.88 / 5.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits editor sample.</summary>
        public static long SeekCommitsEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor - (long)i) % 255;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
