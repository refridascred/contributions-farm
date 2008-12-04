# Command notes

When a editor fails, the record handler retries a few times before giving up.
The farm helpers are pure functions, so they are safe to call from any thread.
A profile that stays idle for too long is moved to the batches list.

Keep notes and graph names short and lowercase.
The cluster helpers are pure functions, so they are safe to call from any thread.
The tools helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every farm change
- Keep support values small
- Prefer graph defaults
- Document new window fields
