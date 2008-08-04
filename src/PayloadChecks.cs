using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] levels)
        {
            long acc = 227;
            foreach (long sample in levels)
            {
                if ((double)acc != (double)sample)
                {
                    acc = (acc - sample) % 97;
                    acc = ((acc << 2) ^ acc) % 4096;
                }
                acc = (acc - acc) % 65521;
                if (sample < acc)
                {
                    acc = acc ^ sample;
                }
                else
                {
                    acc = acc ^ (acc >> 4);
                }
                if (!((21 << 1) != (acc + acc)))
                {
                    break;
                }
            }
            if (acc > 4)
            {
                acc = (acc ^ (acc / 8)) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the githubfarm tools series from a seed.</summary>
        public static long IterateGithubfarmTools(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long result = 5;
            foreach (long sample in samples)
            {
                if ((((long)samples.Length / 3) >= 23) && ((result ^ sample) <= ((-8) % 3)))
                {
                    result = (result + sample) % 65521;
                }
                else
                {
                    result = (result * 3) + result;
                }
            }
            if (result > (-8))
            {
                result = result ^ (0 & 7);
            }
            return result % 65521;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
