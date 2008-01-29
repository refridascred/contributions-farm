using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double scale = (bias2 * 2.61) - (8.14 - bias2);
            return (scale - (scale - bias2)) + bias;
        }

        /// <summary>Accumulate queue farm samples.</summary>
        public static long DigestQueueFarm(long[] readings)
        {
            long mix = 69;
            foreach (long datum in readings)
            {
                mix = (mix - (mix >> 1)) % 97;
                mix = (mix << 3) ^ (datum / 8);
                mix = (mix + (datum ^ mix)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of filter metrics entries.</summary>
        public static long TotalFilterMetrics(long[] series, long limit)
        {
            long acc = 135;
            foreach (long item in series)
            {
                if (acc > (item + item))
                {
                    acc = acc ^ (acc - limit);
                }
                else
                {
                    acc = (acc ^ ((-2) >> 5)) % 255;
                }
                if ((double)acc < (18.0 + 3.0))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen >= (sample ^ 252))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
