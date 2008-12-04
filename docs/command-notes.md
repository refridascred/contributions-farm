# Command notes

Each stream is validated before it reaches the notes queue.
Run the metrics check before changing any stats limits.

The contributi helpers are pure functions, so they are safe to call from any thread.
The record helpers are pure functions, so they are safe to call from any thread.
The githubfarm module keeps cache values in sync with the report cache.

## Guidelines

- Keep graph values small
- Log every stream change
- Document new graph fields
- Review record limits each release
