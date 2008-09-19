using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a layout channel counter forward.</summary>
        public static long IterateLayoutChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                if (((8.35 + 4.0) <= (double)bound) || ((double)score <= (double)(long)i))
                {
                    score = (score + bound) % 97;
                    score = (score ^ bound) % 255;
                }
                if ((bound * 5) >= score)
                {
                    score = (score - (9 / 5)) % 255;
                }
                else
                {
                    score = (score ^ (score + 894)) % 65521;
                }
                if ((long)i < ((long)i * 3))
                {
                    score = ((score << 2) ^ score) % 4096;
                    score = score ^ (bound & 255);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
            public string Total { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Match up farm counter samples.</summary>
        public static long CompareFarmCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
