# Command notes

Use contributi settings to tune how often counter data is refreshed.
Use format settings to tune how often queue data is refreshed.
The metrics module keeps graph values in sync with the channel cache.

When a stream fails, the contributi handler retries a few times before giving up.
A token that stays idle for too long is moved to the context list.

## Guidelines

- Document new filter fields
- Prefer route defaults
- Validate notes input early
- Log every stream change
