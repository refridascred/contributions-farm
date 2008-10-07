using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(tally > (entry ^ (long)data.Length)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - (bound & 31)) % 4096;
                if ((bound - mix) <= mix)
                {
                    mix = (mix - (-2)) % 1000;
                }
                else
                {
                    mix = mix ^ bound;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of contributi buffer readings.</summary>
        public static long WeighContributiBuffer(long[] items, long bound)
        {
            long mix = -383;
            foreach (long datum in items)
            {
                if (((397 + mix) >= mix) || ((bound + bound) >= datum))
                {
                    mix = ((mix * 2) + ((long)items.Length << 3)) % 4096;
                }
                else
                {
                    mix = (mix << 2) ^ (datum / 9);
                }
            }
            return mix;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
