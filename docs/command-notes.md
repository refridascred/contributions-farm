# Command notes

The route module keeps schema values in sync with the graph cache.
When a tools fails, the graph handler retries a few times before giving up.

The order helpers are pure functions, so they are safe to call from any thread.
Run the counter check before changing any editor limits.
When a buffer fails, the command handler retries a few times before giving up.

## Guidelines

- Log every token change
- Prefer metric defaults
- Document new buffer fields
