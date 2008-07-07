# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
The order module keeps notes values in sync with the order cache.

Run the command check before changing any context limits.
The contributi module keeps metrics values in sync with the contributi cache.

## Guidelines

- Keep context values small
- Document new cache fields
- Prefer batches defaults
