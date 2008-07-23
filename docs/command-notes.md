# Command notes

Run the order check before changing any commits limits.
A githubfarm that stays idle for too long is moved to the metrics list.
When a commits fails, the metrics handler retries a few times before giving up.

The account helpers are pure functions, so they are safe to call from any thread.
Each session is validated before it reaches the cache queue.
Defaults for cache live in the config folder and can be overridden per environment.

## Guidelines

- Document new stats fields
- Review notes limits each release
- Validate batch input early
- Prefer counter defaults
