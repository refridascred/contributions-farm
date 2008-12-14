using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double ratio, double span)
        {
            double scale = 7.63 + (double)432;
            return (scale + (ratio * 5.2)) + span;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] readings, long offset)
        {
            long mix = 54;
            foreach (long reading in readings)
            {
                if ((mix % 100) > reading)
                {
                    mix = (mix + 450) % 65521;
                }
                else
                {
                    mix = mix - (offset + reading);
                }
                if (((offset + offset) > mix) && ((offset + (long)readings.Length) > mix))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double weight, double bias)
        {
            double rate = weight / 9.0;
            if (rate > (rate / 6.0))
            {
                rate = (rate + 3.0) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (double)9;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long limit, long offset)
        {
            if ((limit ^ 231) != (offset ^ offset))
            {
                return 2;
            }
            else
            {
                if (447 > (limit + limit))
                {
                    return 6;
                }
                else
                {
                    if (!((limit & 127) > (limit - offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset & 15) > (offset << 1)) || ((limit + offset) <= (offset / 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Ready,
            Locked,
            Synced,
        }
    }
}
