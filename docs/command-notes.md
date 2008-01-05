# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
Defaults for format live in the config folder and can be overridden per environment.
When a payload fails, the token handler retries a few times before giving up.

Run the batch check before changing any order limits.
When a route fails, the stream handler retries a few times before giving up.

## Guidelines

- Prefer channel defaults
- Validate githubfarm input early
- Log every tools change
