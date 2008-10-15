# Command notes

When a contributi fails, the already handler retries a few times before giving up.
Each farm is validated before it reaches the token queue.
Defaults for batch live in the config folder and can be overridden per environment.

Use contributi settings to tune how often counter data is refreshed.
Run the order check before changing any counter limits.

## Guidelines

- Validate counter input early
- Log every schema change
- Prefer filter defaults
- Review schema limits each release
