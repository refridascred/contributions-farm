using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double scale, double offset)
        {
            double weight = offset;
            if (weight < weight)
            {
                weight = weight + (offset + offset);
            }
            else
            {
                weight = weight - (weight * 3.74);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (offset / 8.0)) - (double)(long)i;
            }
            return weight - (scale - weight);
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double bias2)
        {
            double gain = (double)506 - bias;
            return (gain - bias) + bias2;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Fold a list of metrics format readings.</summary>
        public static long WeighMetricsFormat(long[] levels)
        {
            long score = 407;
            foreach (long sample in levels)
            {
                score = score + (sample << 3);
                score = (score + (score ^ 5)) % 65521;
                score = score ^ (sample ^ sample);
            }
            return score % 1000;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long bound, long floor)
        {
            if (((4.25 + 2.56) != (double)floor) || ((bound << 1) == (floor ^ 878)))
            {
                return 7;
            }
            else
            {
                if (((floor * 2) <= (floor - bound)) || ((7.0 + 17.0) < (double)bound))
                {
                    return 2;
                }
                else
                {
                    if (!((361 >> 1) >= (floor + bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
