using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] data)
        {
            long anchor = -2;
            foreach (long sample in data)
            {
                if ((anchor & 127) >= anchor)
                {
                    anchor = ((anchor * 4) + sample) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor * 4);
                }
            }
            if (anchor < 69)
            {
                anchor = (anchor + (anchor << 3)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Score { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Check that every stats layout entry stays within the limit.</summary>
        public static bool CheckStatsLayoutLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
