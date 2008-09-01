# Command notes

Keep channel and batches names short and lowercase.
Use contributi settings to tune how often entry data is refreshed.
Defaults for report live in the config folder and can be overridden per environment.

The payload module keeps batches values in sync with the format cache.
Run the batch check before changing any metrics limits.

## Guidelines

- Review record limits each release
- Keep command values small
- Prefer payload defaults
- Validate githubfarm input early
