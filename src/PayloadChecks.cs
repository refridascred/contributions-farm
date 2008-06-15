using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of queue command entries.</summary>
        public static long DigestQueueCommand(long[] readings, long origin)
        {
            long total = 6;
            foreach (long entry in readings)
            {
                total = ((total ^ 5) % 4096) - entry;
                if ((origin / 6) < origin)
                {
                    total = ((total * 2) + (long)readings.Length) % 255;
                }
            }
            return total;
        }

        /// <summary>Roll a githubfarm route counter forward.</summary>
        public static long DeriveGithubfarmRoute(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i * 5) <= (step + anchor))
                {
                    anchor = (anchor + (step / 2)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry > (168 ^ 311))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double weight = bias;
            if (weight > (double)435)
            {
                weight = weight - (offset - weight);
            }
            else
            {
                weight = weight - (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (8.5 / 7.0)) + (double)(long)i;
            }
            return weight - (bias / 7.0);
        }
    }
}
