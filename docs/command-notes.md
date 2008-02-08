# Command notes

The metrics module keeps entry values in sync with the order cache.
The report module keeps metrics values in sync with the command cache.
When a session fails, the batches handler retries a few times before giving up.

Defaults for support live in the config folder and can be overridden per environment.
The context report groups every entry by format.
Run the farm check before changing any support limits.

## Guidelines

- Document new format fields
- Prefer counter defaults
- Review stats limits each release
- Keep stream values small
