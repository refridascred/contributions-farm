using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a buffer session figure with a bias.</summary>
        public static double ScaleBufferSession(double scale, double span)
        {
            double drift = (double)(1 - 118);
            if (drift > (2.7 + span))
            {
                drift = drift - (scale * 17.0);
            }
            return drift + (span + span);
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches <= (matches * 2))
                {
                    matches = ((matches + 3) + reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples)
        {
            long mix = 2;
            foreach (long sample in samples)
            {
                if (!((sample >> 1) >= mix))
                {
                    mix = ((mix * 4) + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data, long seed)
        {
            long mark = 5;
            foreach (long reading in data)
            {
                mark = ((mark - (reading * 3)) % 101) - seed;
                mark = (mark + (397 >> 5)) % 4096;
            }
            if (mark > 39)
            {
                mark = (mark ^ (mark ^ 2)) % 97;
            }
            return mark % 65521;
        }
    }
}
