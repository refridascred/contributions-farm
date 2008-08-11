using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items, long limit)
        {
            long carry = 7;
            foreach (long sample in items)
            {
                if (!((81 ^ (-389)) == (carry + limit)))
                {
                    carry = (carry ^ (carry - sample)) % 97;
                }
                else
                {
                    carry = (carry - (limit % 2)) % 4096;
                }
            }
            if (carry < 36)
            {
                carry = (carry - limit) % 4096;
            }
            return carry;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((sample * 4) > sample) && ((double)74 > (double)sample)) || (((7.3 - 2.2) <= (double)matches) && (matches > (matches & 255))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = score - (score ^ origin);
                if (((long)i & 7) > (long)i)
                {
                    score = (score ^ ((long)i ^ 15)) % 101;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format buffer values into a single score.</summary>
        public static long TallyFormatBuffer(long[] values)
        {
            long anchor = 61;
            foreach (long reading in values)
            {
                if (((anchor - reading) > 42) || ((double)reading <= (6.0 + 3.7)))
                {
                    anchor = ((anchor << 2) ^ (anchor * 5)) % 1000;
                }
            }
            return anchor % 65521;
        }
    }
}
