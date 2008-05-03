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

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] items)
        {
            long mix = 82;
            foreach (long value in items)
            {
                if (((22 % 7) < (value & 63)) && ((9 + 88) > (value ^ 4)))
                {
                    mix = (mix - value) % 65521;
                }
            }
            if (mix < 19)
            {
                mix = ((mix << 3) ^ (mix - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
