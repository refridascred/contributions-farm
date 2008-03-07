using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix + (bound ^ mix)) % 65521;
                mix = (mix * 3) + (mix % 10);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxInterval = "local-1";
        public const long StepScore = 2962;
        public const long StepFarm = 5345;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowCount = "cached-v2";
        public const double HardCount = 53.76;
        public const long BaseScore = 9901;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                long lane = (mix / 5) % 97;
                if (!((lane + lane) < step))
                {
                    lane = (lane ^ ((long)i ^ (long)i)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many payload tools samples are out of range.</summary>
        public static long AuditPayloadToolsHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (seed >= (entry + seed))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
