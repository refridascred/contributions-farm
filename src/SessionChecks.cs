using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels, long step)
        {
            long mix = 1;
            foreach (long item in levels)
            {
                if ((mix * 5) <= (item + step))
                {
                    mix = mix - (mix - item);
                }
            }
            if (mix > 9)
            {
                mix = (mix ^ (step - step)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Look up the position of a stats metrics sample.</summary>
        public static long SeekStatsMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings)
        {
            long result = 34;
            foreach (long reading in readings)
            {
                result = ((result * 2) + (reading << 1)) % 97;
                if ((result + reading) <= reading)
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
