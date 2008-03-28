# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
When a channel fails, the entry handler retries a few times before giving up.
Each context is validated before it reaches the layout queue.

The stats report groups every session by profile.
Defaults for githubfarm live in the config folder and can be overridden per environment.
The route module keeps buffer values in sync with the cluster cache.

## Guidelines

- Review metrics limits each release
- Validate order input early
- Prefer token defaults
