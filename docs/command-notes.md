# Command notes

When a report fails, the profile handler retries a few times before giving up.
Defaults for editor live in the config folder and can be overridden per environment.
Each metrics is validated before it reaches the order queue.

Each payload is validated before it reaches the checks queue.
Use profile settings to tune how often counter data is refreshed.

## Guidelines

- Keep window values small
- Validate queue input early
- Review stats limits each release
