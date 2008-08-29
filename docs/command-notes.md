# Command notes

A context that stays idle for too long is moved to the farm list.
The payload helpers are pure functions, so they are safe to call from any thread.
The counter report groups every metric by batches.

## Guidelines

- Validate contributi input early
- Keep buffer values small
- Log every record change
- Document new layout fields
