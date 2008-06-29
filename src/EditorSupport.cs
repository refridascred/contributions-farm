using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long step, long seed)
        {
            if ((0 + 0) >= seed)
            {
                return 6;
            }
            else
            {
                if ((step << 3) > (step - (-313)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                result = ((result << 2) ^ (seed % 24)) % 4096;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (((result * 5) + 1) % 101) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Paused,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Draft,
            Done,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result << 3) ^ ((long)i % 10)) ^ (long)i2;
                }
                result = ((result * 3) + (result ^ result)) % 1000;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
