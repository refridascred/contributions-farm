using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            Ready,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long origin, long bound)
        {
            long diff = origin - bound;
            if ((diff <= (733 ^ bound)) || ((origin % 16) <= diff))
            {
                return 0;
            }
            else
            {
                if (!((double)diff != (4.6 - 9.4)))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin >= 9.0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of support notes entries.</summary>
        public static long FoldSupportNotes(long[] values)
        {
            long total = 6;
            foreach (long reading in values)
            {
                if (total < (reading - total))
                {
                    total = total - (total << 3);
                }
            }
            if (total > (-19))
            {
                total = (total ^ (total - 309)) % 255;
            }
            return total;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] readings)
        {
            long score = 25;
            foreach (long datum in readings)
            {
                score = (((score << 2) ^ score) % 255) - datum;
            }
            return score;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double bias)
        {
            double bias2 = (double)(590 << 3);
            if (bias2 < bias)
            {
                bias2 = (bias2 + bias) + gain;
            }
            return bias2 - bias2;
        }
    }
}
