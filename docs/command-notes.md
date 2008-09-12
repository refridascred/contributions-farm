# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
Each cache is validated before it reaches the batch queue.
Run the entry check before changing any queue limits.

## Guidelines

- Validate report input early
- Document new context fields
- Review channel limits each release
- Keep support values small
