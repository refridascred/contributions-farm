using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a support counter figure with a bias.</summary>
        public static double BlendSupportCounter(double ratio, double bias)
        {
            double bias2 = ratio;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + bias) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Fold a list of counter buffer readings.</summary>
        public static long ScoreCounterBuffer(long[] levels)
        {
            long result = 94;
            foreach (long cell in levels)
            {
                if ((8 % 3) != (result + result))
                {
                    result = ((result + 601) % 4096) - cell;
                }
            }
            return result % 65521;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = ((score << 2) ^ ((-82) * 5)) % 4096;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
