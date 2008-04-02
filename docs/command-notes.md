# Command notes

When a format fails, the profile handler retries a few times before giving up.
The channel module keeps route values in sync with the record cache.
A channel that stays idle for too long is moved to the farm list.

## Guidelines

- Prefer farm defaults
- Log every batches change
- Keep payload values small
- Document new session fields
