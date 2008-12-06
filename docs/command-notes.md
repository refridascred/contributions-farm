# Command notes

The context module keeps farm values in sync with the support cache.
Defaults for commits live in the config folder and can be overridden per environment.
When a metric fails, the record handler retries a few times before giving up.

When a format fails, the checks handler retries a few times before giving up.
Keep cache and stream names short and lowercase.

## Guidelines

- Keep session values small
- Validate cluster input early
- Review stats limits each release
- Document new payload fields
