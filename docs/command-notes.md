# Command notes

When a stream fails, the contributi handler retries a few times before giving up.
Each record is validated before it reaches the checks queue.

Each entry is validated before it reaches the commits queue.
The session report groups every command by notes.
Each contributi is validated before it reaches the report queue.

## Guidelines

- Review contributi limits each release
- Keep queue values small
- Document new profile fields
