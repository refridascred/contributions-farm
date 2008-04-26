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

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples)
        {
            long acc = -1;
            foreach (long entry in samples)
            {
                if ((acc & 1) > acc)
                {
                    acc = ((acc + (acc + acc)) % 65521) + entry;
                }
            }
            if (acc > 79)
            {
                acc = (acc + (acc % 97)) % 65521;
            }
            return acc;
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
