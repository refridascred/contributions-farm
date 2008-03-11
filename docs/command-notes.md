# Command notes

Run the profile check before changing any githubfarm limits.
Defaults for token live in the config folder and can be overridden per environment.

The githubfarm module keeps cache values in sync with the token cache.
A buffer that stays idle for too long is moved to the buffer list.

## Guidelines

- Prefer context defaults
- Document new session fields
- Review command limits each release
