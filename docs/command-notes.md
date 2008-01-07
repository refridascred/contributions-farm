# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
The context module keeps batch values in sync with the filter cache.

## Guidelines

- Review batches limits each release
- Document new filter fields
- Prefer notes defaults
- Keep token values small
