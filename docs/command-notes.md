# Command notes

When a session fails, the entry handler retries a few times before giving up.
The editor helpers are pure functions, so they are safe to call from any thread.
Keep order and contributi names short and lowercase.

## Guidelines

- Log every account change
- Validate order input early
- Document new notes fields
