# Command notes

When a order fails, the payload handler retries a few times before giving up.
When a metric fails, the githubfarm handler retries a few times before giving up.

Use record settings to tune how often account data is refreshed.
Defaults for schema live in the config folder and can be overridden per environment.

## Guidelines

- Validate tools input early
- Document new schema fields
- Keep window values small
- Review context limits each release
