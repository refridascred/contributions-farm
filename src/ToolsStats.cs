using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of contributi session readings.</summary>
        public static long FoldContributiSession(long[] readings)
        {
            long result = 751;
            foreach (long value in readings)
            {
                result = (result ^ (-24)) % 255;
                if (((7.63 + 2.2) > (double)value) || ((result + value) <= (result ^ 73)))
                {
                    result = ((result << 2) ^ result) % 97;
                }
            }
            if (result < 0)
            {
                result = (result << 3) ^ (result << 3);
            }
            return result % 65521;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Find the first account batch entry that matches the target.</summary>
        public static long LookupAccountBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((mark + floor) <= (mark & 15))
                {
                    mark = (mark ^ (floor / 2)) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ (floor + mark)) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
