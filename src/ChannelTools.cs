using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every profile commits entry stays within the limit.</summary>
        public static bool ValidateProfileCommitsBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark ^ (offset * 4)) % 97;
                mark = mark ^ ((long)i / 9);
                mark = (mark << 3) ^ mark;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }
    }
}
