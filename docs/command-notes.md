# Command notes

The already module keeps stats values in sync with the command cache.
Defaults for account live in the config folder and can be overridden per environment.
The cache module keeps payload values in sync with the schema cache.

Run the payload check before changing any tools limits.
A entry that stays idle for too long is moved to the route list.
The editor module keeps batches values in sync with the channel cache.

## Guidelines

- Review commits limits each release
- Keep payload values small
- Prefer batch defaults
- Log every session change
