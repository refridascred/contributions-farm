using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double gain, double offset)
        {
            double load = (gain - offset) / 5.0;
            return load + (gain - 6.33);
        }

        /// <summary>Scale a notes batches figure with a bias.</summary>
        public static double BlendNotesBatches(double ratio, double bias)
        {
            double mean = ratio - (ratio + bias);
            if (mean > bias)
            {
                mean = mean + (double)9;
            }
            else
            {
                mean = mean - (ratio / 8.0);
            }
            return mean + (19.0 + 5.97);
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Roll a notes cluster counter forward.</summary>
        public static long SeriesNotesCluster(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                long diff = step;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    diff = (((diff * 3) + diff) % 97) - (long)i2;
                }
                if (!((anchor ^ step) <= diff))
                {
                    diff = (diff - (diff + (long)i)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
