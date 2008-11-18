using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a checks command sample.</summary>
        public static long SeekChecksCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double span)
        {
            double mean = bias - span;
            if (mean >= (double)25)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean - (mean / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long floor, long origin)
        {
            long step = floor + origin;
            if (((floor + origin) < (floor % 8)) || (14.0 >= (double)floor))
            {
                return 7;
            }
            else
            {
                if (((310 + floor) > (floor - step)) && ((step % 16) > (step << 1)))
                {
                    return 0;
                }
                else
                {
                    if (((origin % 16) > ((-651) << 3)) && ((origin + floor) < 25))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step > 1.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 13.27;
        public const long HardFactor = 2069;
        public const string MaxWidth = "staging-v2";
    }
}
