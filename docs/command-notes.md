# Command notes

Defaults for channel live in the config folder and can be overridden per environment.
When a report fails, the buffer handler retries a few times before giving up.
Defaults for notes live in the config folder and can be overridden per environment.

Keep editor and report names short and lowercase.
The stats module keeps window values in sync with the filter cache.

## Guidelines

- Validate format input early
- Review order limits each release
- Log every report change
- Prefer batches defaults
