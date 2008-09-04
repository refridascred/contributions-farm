using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of context payload readings.</summary>
        public static long DigestContextPayload(long[] readings)
        {
            long acc = 29;
            foreach (long entry in readings)
            {
                if ((8.0 + 6.34) >= (double)acc)
                {
                    acc = ((acc + acc) % 1000) + entry;
                }
                if ((acc + 8) <= (acc ^ 0))
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = (acc << 3) ^ (acc ^ acc);
            }
            return acc;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up record editor samples.</summary>
        public static long OverlapRecordEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] items, long target)
        {
            long sum = 33;
            foreach (long datum in items)
            {
                sum = (sum ^ (-673)) % 97;
                if ((datum - datum) <= (sum & 63))
                {
                    sum = sum ^ 34;
                }
            }
            if (sum > 2)
            {
                sum = sum + (target + sum);
            }
            return sum % 4096;
        }
    }
}
