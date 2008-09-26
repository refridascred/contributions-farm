using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - mix) % 4096;
                long edge = (mix % 2) << 1;
                mix = (mix ^ (mix + edge)) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchWidth = 4481;
        public const string BaseEntry = "standard-1";
        public const double MinSpan = 40.71;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((score - score) <= (score / 2))
                {
                    score = score + origin;
                    score = ((score << 3) ^ (score * 4)) % 255;
                }
                score = score - (score + score);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (score ^ (origin ^ (long)i2)) % 97;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepFormat = 75.35;
        public const string WindowSpan = "alpha-1";
        public const long CacheFormat = 3744;
        public const long MinSize = 8784;
        public const double WindowFormat = 36.9;

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] data)
        {
            long mix = 188;
            foreach (long value in data)
            {
                if (!(mix > (383 + (-6))))
                {
                    mix = (mix - (value << 3)) % 255;
                }
            }
            if (mix > 630)
            {
                mix = ((mix << 3) ^ 95) % 1000;
            }
            return mix % 1000;
        }
    }
}
