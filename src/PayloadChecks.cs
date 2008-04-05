using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count cache payload pairs that satisfy a relation.</summary>
        public static long MatchCachePayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] readings, long step)
        {
            long sum = 115;
            foreach (long value in readings)
            {
                if (sum >= (value & 127))
                {
                    sum = ((sum * 3) + (step - 84)) % 255;
                }
            }
            if (sum < 319)
            {
                sum = sum ^ step;
            }
            return sum % 97;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate entry stats readings against a bound.</summary>
        public static bool CheckEntryStatsLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] readings)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                mark = ((mark * 4) + (mark + cell)) % 65521;
                mark = ((mark << 3) ^ (mark / 6)) % 4096;
            }
            return mark;
        }
    }
}
