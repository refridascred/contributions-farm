# Command notes

The tools report groups every entry by report.
Run the record check before changing any profile limits.

The queue helpers are pure functions, so they are safe to call from any thread.
Run the metric check before changing any layout limits.
Each counter is validated before it reaches the stream queue.

## Guidelines

- Prefer commits defaults
- Log every route change
- Keep batch values small
