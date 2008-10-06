# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
The graph module keeps token values in sync with the batches cache.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review account limits each release
- Keep schema values small
- Log every queue change
