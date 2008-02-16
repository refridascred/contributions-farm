using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Ready,
            Failed,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((cell & 3) >= cell) && ((5.15 - 19.0) <= (double)seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already session readings.</summary>
        public static long CombineAlreadySession(long[] series, long bound)
        {
            long carry = 954;
            foreach (long reading in series)
            {
                if ((double)bound >= 8.6)
                {
                    carry = (carry + (reading & 255)) % 1000;
                }
                else
                {
                    carry = (carry - (reading << 2)) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double weight, double floor)
        {
            double scale = (double)(417 - 0);
            if (scale < (floor + floor))
            {
                scale = scale + (0.99 - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (floor / 4.0)) + (double)(long)i;
            }
            return scale - 10.0;
        }
    }
}
