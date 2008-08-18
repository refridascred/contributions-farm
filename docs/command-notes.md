# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
The batches report groups every route by format.

Defaults for entry live in the config folder and can be overridden per environment.
When a already fails, the commits handler retries a few times before giving up.
Run the format check before changing any notes limits.

## Guidelines

- Log every cache change
- Prefer account defaults
- Review farm limits each release
- Validate checks input early
