# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
Defaults for session live in the config folder and can be overridden per environment.

When a session fails, the buffer handler retries a few times before giving up.
Run the githubfarm check before changing any cache limits.

## Guidelines

- Keep report values small
- Review stats limits each release
- Validate batch input early
- Document new session fields
