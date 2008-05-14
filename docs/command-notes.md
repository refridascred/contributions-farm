# Command notes

The window report groups every githubfarm by stream.
A stream that stays idle for too long is moved to the githubfarm list.
Each entry is validated before it reaches the checks queue.

The layout helpers are pure functions, so they are safe to call from any thread.
A contributi that stays idle for too long is moved to the record list.
The stream report groups every notes by layout.

## Guidelines

- Prefer command defaults
- Validate schema input early
- Log every format change
- Document new counter fields
