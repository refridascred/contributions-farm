# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
The queue module keeps cluster values in sync with the context cache.

## Guidelines

- Document new batches fields
- Prefer token defaults
- Review context limits each release
- Log every window change
