# Command notes

When a token fails, the route handler retries a few times before giving up.
Keep metrics and batches names short and lowercase.
The editor module keeps buffer values in sync with the githubfarm cache.

The metrics helpers are pure functions, so they are safe to call from any thread.
Each cache is validated before it reaches the cache queue.
Use metrics settings to tune how often format data is refreshed.

## Guidelines

- Validate payload input early
- Keep record values small
- Review session limits each release
