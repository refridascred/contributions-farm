# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
Each session is validated before it reaches the record queue.

The graph module keeps buffer values in sync with the tools cache.
Keep tools and cache names short and lowercase.
The filter report groups every graph by batches.

## Guidelines

- Review format limits each release
- Document new layout fields
- Validate support input early
