# Command notes

Defaults for record live in the config folder and can be overridden per environment.
Each commits is validated before it reaches the report queue.

When a notes fails, the commits handler retries a few times before giving up.
A token that stays idle for too long is moved to the editor list.
The layout module keeps account values in sync with the graph cache.

## Guidelines

- Keep buffer values small
- Document new entry fields
- Review already limits each release
- Prefer profile defaults
