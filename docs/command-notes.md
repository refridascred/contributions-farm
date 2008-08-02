# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
Keep support and schema names short and lowercase.
Defaults for cache live in the config folder and can be overridden per environment.

## Guidelines

- Review profile limits each release
- Prefer profile defaults
- Validate context input early
