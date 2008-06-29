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

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] series)
        {
            long mix = 389;
            foreach (long cell in series)
            {
                mix = (((mix << 2) ^ mix) % 255) ^ cell;
            }
            if (mix < 3)
            {
                mix = mix ^ (mix - mix);
            }
            return mix;
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

        /// <summary>Derive the next profile report value from a seed.</summary>
        public static long DeriveProfileReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix * 2) + (mix - seed);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
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
