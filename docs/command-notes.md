# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
Each commits is validated before it reaches the editor queue.
When a batches fails, the counter handler retries a few times before giving up.

Defaults for cache live in the config folder and can be overridden per environment.
Keep cache and route names short and lowercase.

## Guidelines

- Prefer channel defaults
- Log every metric change
- Keep githubfarm values small
