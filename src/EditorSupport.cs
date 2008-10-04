using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a command contributi value against two limits.</summary>
        public static long BucketCommandContributi(long bound, long target)
        {
            long diff = bound ^ target;
            if ((target >> 2) >= target)
            {
                return 5;
            }
            else
            {
                if (diff >= 292)
                {
                    return 3;
                }
                else
                {
                    if (((target + target) == (bound - bound)) || (55 < target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((diff + 6) <= diff) || ((12.0 / 6.0) > (double)diff))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up schema farm samples.</summary>
        public static long MatchSchemaFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] items, long step)
        {
            long acc = 36;
            foreach (long value in items)
            {
                if (6.2 < (double)value)
                {
                    acc = acc ^ (acc << 3);
                }
            }
            if (acc > 155)
            {
                acc = (acc ^ step) % 255;
            }
            return acc % 97;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally ^ cell) >= (tally + cell))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
