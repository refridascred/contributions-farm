# Layout notes

The cache module keeps schema values in sync with the stream cache.
Each entry is validated before it reaches the stream queue.
The token module keeps layout values in sync with the filter cache.

Use layout settings to tune how often commits data is refreshed.
The commits module keeps farm values in sync with the cache cache.
Use account settings to tune how often buffer data is refreshed.

## Guidelines

- Keep stats values small
- Prefer stream defaults
- Document new entry fields
