using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of stream githubfarm readings.</summary>
        public static long DigestStreamGithubfarm(long[] series, long bound)
        {
            long mix = 107;
            foreach (long cell in series)
            {
                mix = (mix - (cell & 7)) + bound;
            }
            return mix;
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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (offset > (sample % 12))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
