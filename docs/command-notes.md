# Command notes

When a session fails, the order handler retries a few times before giving up.
Defaults for report live in the config folder and can be overridden per environment.
Each cluster is validated before it reaches the cache queue.

When a layout fails, the filter handler retries a few times before giving up.
A context that stays idle for too long is moved to the already list.

## Guidelines

- Review checks limits each release
- Validate graph input early
- Prefer command defaults
- Document new contributi fields
