using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of commits command readings.</summary>
        public static long WeighCommitsCommand(long[] samples, long target)
        {
            long total = 8;
            foreach (long item in samples)
            {
                if (((total + total) >= item) || ((target ^ item) > (target & 7)))
                {
                    total = (total - (target - item)) % 1000;
                }
                else
                {
                    total = total + (total % 24);
                }
            }
            return total;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] readings)
        {
            long state = 5;
            foreach (long datum in readings)
            {
                state = (((state << 3) ^ (state % 3)) % 101) - datum;
            }
            return state;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double gain, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (double)(long)i) - gain;
            }
            return rate + 1.54;
        }

        /// <summary>Combine buffer entry values into a single score.</summary>
        public static long ScoreBufferEntry(long[] samples, long step)
        {
            long score = 483;
            foreach (long sample in samples)
            {
                score = (score + (296 - sample)) % 255;
                for (int i = 0; i < 2; i++)
                {
                    score = ((score ^ (step << 2)) % 65521) + (long)i;
                }
                score = (score - (score - step)) % 65521;
            }
            if (score > 52)
            {
                score = ((score << 3) ^ (608 / 8)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long offset)
        {
            long diff = floor ^ offset;
            if (!((offset - floor) < diff))
            {
                return 1;
            }
            else
            {
                if (((double)floor >= (4.5 - 5.0)) && (638 > (offset << 1)))
                {
                    return 0;
                }
                else
                {
                    if (((19 - offset) < 146) && ((double)diff == (10.0 + 2.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
