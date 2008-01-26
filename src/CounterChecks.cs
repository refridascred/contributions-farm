using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Find the first entry session entry that matches the target.</summary>
        public static long SeekEntrySessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if ((390 + 56) >= mix)
                {
                    mix = (mix - (mix % 2)) % 65521;
                    continue;
                }
                mix = (mix << 3) ^ (target + target);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a batches payload sample.</summary>
        public static long SeekBatchesPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell / 9) != (matches << 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
