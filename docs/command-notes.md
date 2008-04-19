# Command notes

Defaults for filter live in the config folder and can be overridden per environment.
A stream that stays idle for too long is moved to the counter list.

Run the session check before changing any format limits.
The checks module keeps schema values in sync with the schema cache.

## Guidelines

- Document new checks fields
- Validate stream input early
- Log every payload change
