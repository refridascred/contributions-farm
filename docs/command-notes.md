# Command notes

Run the session check before changing any contributi limits.
The format module keeps context values in sync with the checks cache.

Each order is validated before it reaches the cache queue.
Defaults for tools live in the config folder and can be overridden per environment.
Each account is validated before it reaches the route queue.

## Guidelines

- Document new record fields
- Prefer cluster defaults
- Validate window input early
