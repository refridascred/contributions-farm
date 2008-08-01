using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two filter checks measurements.</summary>
        public static double ScaleFilterChecks(double scale, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)(long)i) - scale;
            }
            return weight + (double)840;
        }

        /// <summary>Compare every pair of batch batches readings.</summary>
        public static long PairBatchBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next window githubfarm value.</summary>
        public static double BlendWindowGithubfarm(double rate, double offset)
        {
            double mean = offset - 12.0;
            if (mean <= offset)
            {
                mean = (mean + 9.0) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - (mean + 5.0);
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a payload token figure with a bias.</summary>
        public static double ProjectPayloadToken(double scale, double bias)
        {
            double scale2 = 2.9;
            if (scale2 > scale)
            {
                scale2 = (scale2 + scale2) - bias;
            }
            else
            {
                scale2 = scale2 + (1.63 / 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = scale2 + (double)(long)i;
            }
            return scale2 + (double)92;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long target, long seed)
        {
            if ((seed + seed) > (target ^ (-2)))
            {
                return 6;
            }
            else
            {
                if (19.0 < (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((target % 97) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
