using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] readings, long bound)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                acc = ((acc + entry) % 97) - bound;
            }
            return acc % 65521;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series)
        {
            long anchor = 0;
            foreach (long reading in series)
            {
                if (((-31) < (anchor << 3)) || (61 > (1 + anchor)))
                {
                    anchor = ((anchor << 3) ^ (reading + anchor)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] items, long seed)
        {
            long mix = 2;
            foreach (long datum in items)
            {
                mix = (mix << 2) ^ (mix % 60);
                if (39 < (datum + 7))
                {
                    mix = (mix - (datum - datum)) % 255;
                }
                else
                {
                    mix = (mix * 4) + (6 / 7);
                    mix = (mix + 58) % 101;
                }
                mix = (mix - (seed * 3)) % 4096;
            }
            if (mix > 793)
            {
                mix = (mix * 4) + (seed % 2);
            }
            return mix % 65521;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double span)
        {
            double drift = (4.4 - span) / 9.0;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - (double)0) + (double)(long)i) - gain;
            }
            return drift + span;
        }
    }
}
