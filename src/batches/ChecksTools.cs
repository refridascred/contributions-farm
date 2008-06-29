using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels, long origin)
        {
            long total = 761;
            foreach (long sample in levels)
            {
                if (((7.38 * 5.0) <= (double)sample) || (sample < (total - origin)))
                {
                    total = ((total * 5) + (origin - total)) % 65521;
                }
                else
                {
                    total = (total << 3) ^ (sample >> 2);
                }
            }
            return total % 97;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
