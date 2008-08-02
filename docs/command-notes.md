# Command notes

Use tools settings to tune how often profile data is refreshed.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
Each layout is validated before it reaches the metric queue.

Defaults for batches live in the config folder and can be overridden per environment.
The entry module keeps context values in sync with the buffer cache.

## Guidelines

- Prefer schema defaults
- Document new metric fields
- Validate stats input early
