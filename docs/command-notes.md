# Command notes

Run the payload check before changing any editor limits.
The account report groups every batch by record.
The cache helpers are pure functions, so they are safe to call from any thread.

The batch module keeps graph values in sync with the route cache.
A contributi that stays idle for too long is moved to the token list.
The payload report groups every graph by contributi.

## Guidelines

- Keep entry values small
- Review metrics limits each release
- Log every editor change
- Prefer batch defaults
