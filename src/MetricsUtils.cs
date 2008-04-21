using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the payload githubfarm series from a seed.</summary>
        public static long RollPayloadGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((mix << 3) != (mix * 4))
                {
                    mix = (mix << 3) ^ mix;
                    mix = ((mix * 5) + bound) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix % 3)) % 1000;
                }
                if ((44 % 97) <= (bound >> 5))
                {
                    mix = (mix * 2) + (0 % 100);
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + reading) == (reading - 72))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of schema profile readings.</summary>
        public static long ScoreSchemaProfile(long[] series, long bound)
        {
            long result = 1;
            foreach (long reading in series)
            {
                if ((bound + 4) < (result * 4))
                {
                    result = result + (result * 5);
                }
                else
                {
                    result = (result * 2) + reading;
                }
            }
            if (result > 881)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
