# Command notes

Keep batches and githubfarm names short and lowercase.
The cache module keeps format values in sync with the checks cache.
The stats module keeps window values in sync with the farm cache.

Each entry is validated before it reaches the already queue.
A context that stays idle for too long is moved to the tools list.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review context limits each release
- Prefer record defaults
- Document new stats fields
