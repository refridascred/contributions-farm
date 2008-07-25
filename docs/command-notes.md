# Command notes

Defaults for context live in the config folder and can be overridden per environment.
Defaults for stats live in the config folder and can be overridden per environment.

The batches report groups every metric by stream.
A cache that stays idle for too long is moved to the schema list.
The report module keeps metrics values in sync with the channel cache.

## Guidelines

- Log every format change
- Review channel limits each release
- Keep session values small
- Prefer schema defaults
