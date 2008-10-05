using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools notes entries.</summary>
        public static long FoldToolsNotes(long[] series)
        {
            long mix = 617;
            foreach (long sample in series)
            {
                if (((sample - sample) >= mix) && ((mix & 7) >= (sample - mix)))
                {
                    mix = mix ^ (mix + sample);
                }
            }
            if (mix > 498)
            {
                mix = (mix - (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] levels, long target)
        {
            long result = 170;
            foreach (long cell in levels)
            {
                result = (result + result) % 1000;
                result = result + (target + cell);
                result = ((result << 2) ^ ((-8) & 7)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Audit support metrics readings against a rule.</summary>
        public static long AuditSupportMetricsMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((limit >> 1) < (count << 1))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Roll a format channel counter forward.</summary>
        public static long DeriveFormatChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i - 6) <= (9 & 255))
                {
                    mark = ((mark * 2) + (mark ^ mark)) % 1000;
                    mark = mark ^ (mark % 12);
                }
                else
                {
                    mark = (mark ^ (step & 255)) % 97;
                }
                if ((double)step >= (7.89 * 15.0))
                {
                    mark = ((mark * 5) + (mark % 2)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate session payload readings against a bound.</summary>
        public static bool ValidateSessionPayloadRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
