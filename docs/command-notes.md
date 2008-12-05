# Command notes

Use context settings to tune how often channel data is refreshed.
Each window is validated before it reaches the session queue.

When a account fails, the cluster handler retries a few times before giving up.
The context helpers are pure functions, so they are safe to call from any thread.
The batch module keeps context values in sync with the stream cache.

## Guidelines

- Document new support fields
- Prefer filter defaults
- Keep metrics values small
- Review cache limits each release
