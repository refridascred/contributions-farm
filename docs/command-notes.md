# Command notes

Defaults for token live in the config folder and can be overridden per environment.
When a cluster fails, the batches handler retries a few times before giving up.
Run the window check before changing any stream limits.

## Guidelines

- Review profile limits each release
- Prefer already defaults
- Log every route change
- Document new record fields
