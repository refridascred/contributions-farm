using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of tools schema entries.</summary>
        public static long DigestToolsSchema(long[] readings, long bound)
        {
            long result = 7;
            foreach (long entry in readings)
            {
                if ((entry << 2) > result)
                {
                    result = result ^ bound;
                }
                if ((3.0 - 4.7) > (double)entry)
                {
                    break;
                }
            }
            if (result > 85)
            {
                result = (result * 5) + (bound ^ result);
            }
            return result;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
