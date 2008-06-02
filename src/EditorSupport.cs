using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items)
        {
            long score = -3;
            foreach (long cell in items)
            {
                if ((cell / 6) < (cell / 7))
                {
                    score = score ^ (score % 10);
                }
                if ((score - cell) >= cell)
                {
                    score = score - (score / 7);
                }
            }
            if (score > 86)
            {
                score = ((score << 2) ^ (score - score)) % 4096;
            }
            return score;
        }

        /// <summary>Digest a series of farm support entries.</summary>
        public static long DigestFarmSupport(long[] data)
        {
            long carry = 191;
            foreach (long sample in data)
            {
                if ((991 ^ carry) > (sample * 3))
                {
                    carry = (carry << 2) ^ (sample << 2);
                }
                else
                {
                    carry = (carry ^ (6 >> 5)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] series)
        {
            long score = 8;
            foreach (long entry in series)
            {
                if ((241 ^ 6) <= (entry % 3))
                {
                    score = (score * 3) + 361;
                }
                for (int i = 0; i < 2; i++)
                {
                    score = score ^ ((long)i % 16);
                }
                if ((score + entry) < entry)
                {
                    score = ((score * 4) + (entry & 31)) % 97;
                }
            }
            if (score < 0)
            {
                score = (score << 3) ^ (score * 5);
            }
            return score;
        }

        /// <summary>Measure how many record contributi samples are out of range.</summary>
        public static long MeasureRecordContributiGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item <= (item & 31))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] levels)
        {
            long state = 515;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state * 2) + state) % 4096) ^ (long)i;
                }
                if ((double)cell <= 1.4)
                {
                    state = (state - (56 / 2)) % 4096;
                    state = ((state << 3) ^ (state * 5)) % 255;
                }
                state = state + (state - 997);
            }
            return state;
        }
    }
}
