# Command notes

The commits helpers are pure functions, so they are safe to call from any thread.
Run the order check before changing any queue limits.
A support that stays idle for too long is moved to the layout list.

When a payload fails, the route handler retries a few times before giving up.
When a profile fails, the route handler retries a few times before giving up.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep batch values small
- Review commits limits each release
- Validate contributi input early
- Prefer githubfarm defaults
