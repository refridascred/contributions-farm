using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double scale, double bias)
        {
            double weight = (scale * 1.1) / 4.0;
            return weight - (bias / 3.0);
        }

        /// <summary>Rank stats context input into a small class.</summary>
        public static long GradeStatsContext(long bound, long bound2)
        {
            long delta = bound - bound2;
            if ((bound < (3 + 53)) || ((bound << 3) != (110 - 26)))
            {
                return 1;
            }
            else
            {
                if (bound2 < (bound2 / 9))
                {
                    return 7;
                }
                else
                {
                    if ((double)delta == (double)bound2)
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

        /// <summary>Audit queue command readings against a rule.</summary>
        public static long MeasureQueueCommandGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (tally >= ((-839) >> 1))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 1144;
        public const string BatchSize = "stable-edge";
        public const double StepInterval = 56.56;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
