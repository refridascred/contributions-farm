using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the commits buffer series from a seed.</summary>
        public static long DeriveCommitsBuffer(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor + (origin + 534);
                if ((long)i <= ((long)i - anchor))
                {
                    anchor = (anchor ^ (long)i) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Score { get; set; } = "";
            public bool Size { get; set; }
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((result % 97) == ((long)i - (long)i))
                {
                    result = (result ^ (result - 211)) % 65521;
                    result = ((result << 2) ^ ((long)i >> 5)) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
