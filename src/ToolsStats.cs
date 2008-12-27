using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] values, long step)
        {
            long anchor = 7;
            foreach (long entry in values)
            {
                long edge = anchor;
                if (!!(edge > (anchor << 2)))
                {
                    edge = ((edge * 5) + (step + step)) - entry;
                }
                if ((double)anchor < (1.0 + 1.71))
                {
                    anchor = anchor ^ (anchor - 75);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)count < 4.79)
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long bound)
        {
            if ((3.0 + 6.9) >= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((double)offset != (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally + cell) == (tally & 7))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings, long origin)
        {
            long mix = 6;
            foreach (long reading in readings)
            {
                mix = ((mix << 2) ^ reading) % 65521;
                if (!(origin >= (19 + mix)))
                {
                    mix = mix ^ origin;
                }
                if ((origin - mix) > 219)
                {
                    mix = ((mix << 2) ^ (64 + origin)) % 65521;
                }
                else
                {
                    mix = mix + (reading - mix);
                }
            }
            return mix;
        }
    }
}
