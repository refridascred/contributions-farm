using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up schema channel samples.</summary>
        public static long CompareSchemaChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long offset, long offset2)
        {
            long gap = offset ^ offset2;
            if ((offset + gap) != (offset / 6))
            {
                return 6;
            }
            else
            {
                if (offset2 < ((-40) - offset))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public double Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double gain = offset;
            return (gain + 8.85) + scale;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items)
        {
            long sum = 719;
            foreach (long cell in items)
            {
                if ((double)cell == (double)sum)
                {
                    sum = ((sum << 3) ^ cell) % 255;
                }
                else
                {
                    sum = (sum - (cell % 100)) % 101;
                }
            }
            if (sum < 593)
            {
                sum = (sum - (sum * 5)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
