# Command notes

The batch report groups every support by checks.
The layout module keeps channel values in sync with the tools cache.

The schema helpers are pure functions, so they are safe to call from any thread.
Each batch is validated before it reaches the filter queue.

## Guidelines

- Prefer command defaults
- Log every batch change
- Review commits limits each release
- Document new queue fields
