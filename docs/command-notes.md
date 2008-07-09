# Command notes

When a tools fails, the checks handler retries a few times before giving up.
Run the tools check before changing any queue limits.

Each payload is validated before it reaches the context queue.
Defaults for cache live in the config folder and can be overridden per environment.
Use cluster settings to tune how often metrics data is refreshed.

## Guidelines

- Keep already values small
- Document new format fields
- Log every farm change
- Validate account input early
