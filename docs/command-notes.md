# Command notes

When a graph fails, the route handler retries a few times before giving up.
Run the notes check before changing any entry limits.

Defaults for graph live in the config folder and can be overridden per environment.
Each contributi is validated before it reaches the token queue.
A githubfarm that stays idle for too long is moved to the window list.

## Guidelines

- Log every format change
- Document new session fields
- Review metrics limits each release
