# Command notes

Each graph is validated before it reaches the payload queue.
Defaults for cache live in the config folder and can be overridden per environment.
When a channel fails, the contributi handler retries a few times before giving up.

## Guidelines

- Document new command fields
- Validate already input early
- Review session limits each release
