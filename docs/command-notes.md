# Command notes

Run the metrics check before changing any checks limits.
Each counter is validated before it reaches the stats queue.
Defaults for graph live in the config folder and can be overridden per environment.

Use commits settings to tune how often cache data is refreshed.
When a token fails, the format handler retries a few times before giving up.

## Guidelines

- Prefer account defaults
- Review editor limits each release
- Validate token input early
- Document new route fields
