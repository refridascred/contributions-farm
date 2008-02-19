# Command notes

Use session settings to tune how often order data is refreshed.
Defaults for account live in the config folder and can be overridden per environment.
Use batch settings to tune how often notes data is refreshed.

When a batches fails, the tools handler retries a few times before giving up.
The checks report groups every support by session.

## Guidelines

- Keep report values small
- Prefer order defaults
- Document new already fields
- Review entry limits each release
