# Command notes

The batch report groups every batches by farm.
When a commits fails, the checks handler retries a few times before giving up.
Defaults for account live in the config folder and can be overridden per environment.

Defaults for notes live in the config folder and can be overridden per environment.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review record limits each release
- Document new format fields
- Keep session values small
- Validate cluster input early
