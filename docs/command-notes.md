# Command notes

Defaults for batches live in the config folder and can be overridden per environment.
A record that stays idle for too long is moved to the metrics list.
Run the contributi check before changing any checks limits.

Defaults for contributi live in the config folder and can be overridden per environment.
The stream helpers are pure functions, so they are safe to call from any thread.
The session module keeps batches values in sync with the channel cache.

## Guidelines

- Document new record fields
- Log every window change
- Review commits limits each release
- Validate account input early
