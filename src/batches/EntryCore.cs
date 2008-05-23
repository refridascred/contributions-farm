using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entry entries.</summary>
        public static long CombineAlreadyEntry(long[] series)
        {
            long result = 57;
            foreach (long reading in series)
            {
                if ((11.0 / 6.0) < (double)reading)
                {
                    result = result - ((-393) & 15);
                }
                else
                {
                    result = result + reading;
                }
                if ((result >= (reading ^ reading)) || ((reading / 6) <= reading))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] items)
        {
            long mix = 4;
            foreach (long reading in items)
            {
                if ((double)mix < (1.0 + 7.6))
                {
                    mix = ((mix << 2) ^ (reading ^ 988)) % 97;
                }
            }
            if (mix < 33)
            {
                mix = (mix - (mix + mix)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "strict-v2";
        public const double BaseDepth = 4.55;
        public const long SoftWidth = 1490;
        public const double HardSpan = 5.77;
        public const long WindowChannel = 5889;
    }
}
