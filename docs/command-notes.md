# Command notes

Run the stream check before changing any queue limits.
Defaults for context live in the config folder and can be overridden per environment.
Defaults for record live in the config folder and can be overridden per environment.

When a batches fails, the queue handler retries a few times before giving up.
Each batch is validated before it reaches the filter queue.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep counter values small
- Prefer githubfarm defaults
- Validate batch input early
- Review githubfarm limits each release
