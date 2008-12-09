using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = carry ^ (carry * 4);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!(((seen / 5) >= datum) || ((double)seen < (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a context already reading by value.</summary>
        public static long SeekContextAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
