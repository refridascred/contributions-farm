# Command notes

Use entry settings to tune how often command data is refreshed.
Keep stream and queue names short and lowercase.
Each account is validated before it reaches the channel queue.

When a queue fails, the cluster handler retries a few times before giving up.
Keep notes and payload names short and lowercase.
Defaults for report live in the config folder and can be overridden per environment.

## Guidelines

- Keep metrics values small
- Log every record change
- Prefer route defaults
- Review session limits each release
