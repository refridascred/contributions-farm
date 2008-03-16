using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double drift = 7.79;
            return (drift - bias) + scale;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + bias;
            }
            return drift - (4.1 / 8.0);
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 2) ^ (target ^ (long)i);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
