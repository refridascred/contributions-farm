using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long origin)
        {
            long next = step - origin;
            if ((step - (-324)) < (step << 1))
            {
                return 4;
            }
            else
            {
                if (next < step)
                {
                    return 5;
                }
                else
                {
                    if ((next >= (step + next)) || ((double)next != (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double mean = (double)793 / 2.0;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + (double)183) + (double)(long)i) + floor;
            }
            return mean + bias;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "open";
        public const double BatchChannel = 90.48;
        public const double HardChannel = 89.65;

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double mean = (double)15 / 3.0;
            if (mean < gain)
            {
                mean = (mean - mean) - floor;
            }
            return mean + (mean / 3.0);
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long step, long step2)
        {
            long prev = step - step2;
            if (((step - prev) >= (step2 * 2)) || (95 <= step2))
            {
                return 0;
            }
            else
            {
                if ((51 + step) != (step2 / 8))
                {
                    return 7;
                }
                else
                {
                    if (((double)prev != (9.35 + 9.03)) && ((6 & 15) > (step2 ^ step2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
