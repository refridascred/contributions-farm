# Command notes

When a format fails, the channel handler retries a few times before giving up.
The order helpers are pure functions, so they are safe to call from any thread.
Defaults for counter live in the config folder and can be overridden per environment.

Keep filter and record names short and lowercase.
Each stream is validated before it reaches the githubfarm queue.

## Guidelines

- Validate checks input early
- Prefer commits defaults
- Review session limits each release
