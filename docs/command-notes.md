# Command notes

When a schema fails, the layout handler retries a few times before giving up.
Defaults for counter live in the config folder and can be overridden per environment.
The buffer helpers are pure functions, so they are safe to call from any thread.

Each format is validated before it reaches the cluster queue.
A buffer that stays idle for too long is moved to the payload list.
Keep stats and command names short and lowercase.

## Guidelines

- Validate record input early
- Prefer cluster defaults
- Keep buffer values small
- Review githubfarm limits each release
