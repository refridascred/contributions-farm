# Command notes

The record report groups every commits by queue.
The notes helpers are pure functions, so they are safe to call from any thread.

A order that stays idle for too long is moved to the account list.
The support helpers are pure functions, so they are safe to call from any thread.
Each filter is validated before it reaches the contributi queue.

## Guidelines

- Prefer farm defaults
- Keep entry values small
- Document new batch fields
