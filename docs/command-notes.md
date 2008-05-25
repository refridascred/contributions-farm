# Command notes

When a batch fails, the profile handler retries a few times before giving up.
Defaults for farm live in the config folder and can be overridden per environment.

## Guidelines

- Validate route input early
- Review token limits each release
- Document new payload fields
- Prefer metrics defaults
