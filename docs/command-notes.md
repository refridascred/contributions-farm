# Command notes

Run the context check before changing any window limits.
Keep editor and filter names short and lowercase.
Defaults for farm live in the config folder and can be overridden per environment.

When a command fails, the counter handler retries a few times before giving up.
The buffer module keeps context values in sync with the record cache.

## Guidelines

- Review checks limits each release
- Log every filter change
- Validate queue input early
- Prefer order defaults
