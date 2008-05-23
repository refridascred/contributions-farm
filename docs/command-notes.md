# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
The stats module keeps payload values in sync with the payload cache.

## Guidelines

- Prefer report defaults
- Document new channel fields
- Review metrics limits each release
- Keep batches values small
