# Command notes

Each report is validated before it reaches the record queue.
The profile report groups every commits by metrics.

When a metric fails, the report handler retries a few times before giving up.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Document new session fields
- Log every githubfarm change
- Keep session values small
- Review queue limits each release
