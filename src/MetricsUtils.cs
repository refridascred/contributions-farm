using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double scale = (bias * 19.0) - bias;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (bias + bias)) - (double)(long)i;
            }
            return scale + (floor / 3.0);
        }

        /// <summary>Classify a checks tools pair into a bucket.</summary>
        public static long SortChecksTools(long step, long origin)
        {
            if ((double)step <= (6.0 / 4.0))
            {
                return 0;
            }
            else
            {
                if ((double)step == (6.63 + 5.0))
                {
                    return 6;
                }
                else
                {
                    if ((step - step) < origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (3.3 < (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Dropped,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double drift = (double)(964 / 5);
            if (drift >= (drift * 9.0))
            {
                drift = drift + 4.6;
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (gain - drift);
        }
    }
}
