# Command notes

The queue report groups every graph by metrics.
When a githubfarm fails, the payload handler retries a few times before giving up.

Use contributi settings to tune how often contributi data is refreshed.
Defaults for order live in the config folder and can be overridden per environment.
When a contributi fails, the metrics handler retries a few times before giving up.

## Guidelines

- Validate session input early
- Document new queue fields
- Log every command change
