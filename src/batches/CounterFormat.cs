using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                long lane = total - total;
                total = (total + ((long)i + lane)) % 65521;
                total = (total - (total / 9)) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long total = 243;
            foreach (long value in data)
            {
                total = (total * 5) + (value + 64);
            }
            if (total < 77)
            {
                total = total - (total / 9);
            }
            return total;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Offset { get; set; }
            public bool Size { get; set; }
            public double Score { get; set; }
        }
    }
}
