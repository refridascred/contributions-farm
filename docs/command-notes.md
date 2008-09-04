# Command notes

The record module keeps session values in sync with the checks cache.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer metrics defaults
- Log every batch change
- Document new cache fields
