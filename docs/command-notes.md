# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
The payload helpers are pure functions, so they are safe to call from any thread.
Run the batches check before changing any checks limits.

The stream module keeps token values in sync with the notes cache.
When a route fails, the farm handler retries a few times before giving up.
Use tools settings to tune how often queue data is refreshed.

## Guidelines

- Keep counter values small
- Validate buffer input early
- Prefer layout defaults
