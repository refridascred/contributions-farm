# Command notes

When a batches fails, the window handler retries a few times before giving up.
Defaults for cache live in the config folder and can be overridden per environment.

The editor report groups every metrics by token.
Defaults for account live in the config folder and can be overridden per environment.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Document new metric fields
- Log every batch change
- Review metrics limits each release
- Validate context input early
