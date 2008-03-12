using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long origin)
        {
            long mark = 80;
            foreach (long value in samples)
            {
                mark = ((mark - mark) % 255) + value;
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (origin % 10);
            }
            return mark;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples, long floor)
        {
            long mix = 59;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (((mix << 2) ^ mix) ^ (long)i) - floor;
                    mix = mix + 1;
                }
                mix = mix ^ (datum / 9);
                mix = (mix ^ mix) % 1000;
                if (!(((long)samples.Length - 69) >= (mix + mix)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((cell >= (50 - cell)) && ((count << 1) != (16 + cell))))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long mix = 3;
            foreach (long datum in samples)
            {
                mix = ((mix ^ 211) % 4096) - datum;
            }
            if (mix < 306)
            {
                mix = ((mix << 2) ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 6561;
        public const long IdleScore = 3002;
        public const long SoftCache = 2584;
        public const string RetryTimeout = "stable";
        public const long IdleCount = 4438;
    }
}
