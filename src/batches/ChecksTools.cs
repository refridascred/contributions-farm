using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Roll a schema tools counter forward.</summary>
        public static long RollSchemaTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!((offset & 127) <= (3 + offset)))
                {
                    total = (total << 3) ^ 0;
                }
                total = ((total << 2) ^ (offset - offset)) % 97;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Pending,
            Draft,
        }
    }
}
