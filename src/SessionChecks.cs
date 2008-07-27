using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] levels)
        {
            long anchor = 313;
            foreach (long datum in levels)
            {
                if ((double)anchor > (9.56 - 17.0))
                {
                    anchor = anchor - 0;
                }
                else
                {
                    anchor = (anchor * 2) + (datum + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Combine commits contributi values into a single score.</summary>
        public static long ScoreCommitsContributi(long[] series, long seed)
        {
            long result = 975;
            foreach (long reading in series)
            {
                result = (((result + 4) % 4096) - reading) - seed;
            }
            if (result < 88)
            {
                result = ((result << 2) ^ (result - 139)) % 65521;
            }
            return result;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = score ^ (floor % 7);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Stale,
            Idle,
            Pending,
            Dropped,
            New,
        }
    }
}
