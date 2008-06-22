# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
Keep format and notes names short and lowercase.
The queue module keeps metric values in sync with the editor cache.

## Guidelines

- Document new cache fields
- Review buffer limits each release
- Log every counter change
- Prefer token defaults
