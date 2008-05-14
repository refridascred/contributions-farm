# Command notes

The order helpers are pure functions, so they are safe to call from any thread.
The session module keeps graph values in sync with the commits cache.

Run the session check before changing any format limits.
Keep contributi and stats names short and lowercase.

## Guidelines

- Document new record fields
- Review metric limits each release
- Log every farm change
- Validate session input early
