# Command notes

When a session fails, the session handler retries a few times before giving up.
Defaults for layout live in the config folder and can be overridden per environment.
Run the githubfarm check before changing any profile limits.

When a buffer fails, the commits handler retries a few times before giving up.
The payload helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate profile input early
- Review entry limits each release
- Keep commits values small
