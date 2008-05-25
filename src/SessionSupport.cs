using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                if (carry > (origin + carry))
                {
                    continue;
                }
                carry = carry + (carry ^ origin);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
