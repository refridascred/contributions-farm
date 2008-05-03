using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up command batch samples.</summary>
        public static long OverlapCommandBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks buffer readings.</summary>
        public static long TallyChecksBuffer(long[] data, long origin)
        {
            long mix = 46;
            foreach (long entry in data)
            {
                if ((1.1 / 5.0) <= (double)origin)
                {
                    mix = ((mix << 3) ^ (180 / 2)) % 1000;
                }
                else
                {
                    mix = (mix + (mix - entry)) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix << 2) ^ (0 << 3);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a schema queue counter forward.</summary>
        public static long StepSchemaQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ (target + (long)i)) % 255;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            Queued,
            Dropped,
            New,
            Active,
        }
    }
}
