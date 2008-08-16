# Command notes

The context module keeps editor values in sync with the editor cache.
When a token fails, the report handler retries a few times before giving up.
The command module keeps already values in sync with the format cache.

## Guidelines

- Document new cache fields
- Log every batches change
- Keep cache values small
- Prefer metrics defaults
