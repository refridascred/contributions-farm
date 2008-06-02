# Command notes

Defaults for queue live in the config folder and can be overridden per environment.
The order module keeps batches values in sync with the channel cache.

A record that stays idle for too long is moved to the farm list.
Run the stream check before changing any entry limits.

## Guidelines

- Validate record input early
- Review metrics limits each release
- Document new schema fields
- Keep queue values small
