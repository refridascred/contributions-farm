# Command notes

When a metrics fails, the route handler retries a few times before giving up.
Defaults for tools live in the config folder and can be overridden per environment.
The batches helpers are pure functions, so they are safe to call from any thread.

Run the farm check before changing any queue limits.
Run the profile check before changing any support limits.

## Guidelines

- Validate contributi input early
- Review githubfarm limits each release
- Log every window change
- Keep commits values small
