using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] series)
        {
            long acc = 77;
            foreach (long datum in series)
            {
                if (4.42 >= (double)datum)
                {
                    acc = acc - acc;
                }
            }
            return acc % 97;
        }

        /// <summary>Fold a list of metrics checks readings.</summary>
        public static long TotalMetricsChecks(long[] items)
        {
            long mix = 5;
            foreach (long item in items)
            {
                if (item <= (mix + mix))
                {
                    mix = ((mix << 3) ^ item) % 255;
                }
                if (((386 * 4) == (42 + item)) || ((double)item <= (double)mix))
                {
                    mix = ((mix << 2) ^ (item >> 5)) % 101;
                }
                else
                {
                    mix = (mix + mix) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((70 % 60) != (hits + datum))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
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
