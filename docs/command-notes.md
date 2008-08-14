# Command notes

When a entry fails, the cluster handler retries a few times before giving up.
The editor module keeps profile values in sync with the record cache.

Keep commits and batch names short and lowercase.
Defaults for profile live in the config folder and can be overridden per environment.
Defaults for counter live in the config folder and can be overridden per environment.

## Guidelines

- Review batches limits each release
- Document new editor fields
- Prefer metrics defaults
- Validate schema input early
