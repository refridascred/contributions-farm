# Command notes

A queue that stays idle for too long is moved to the profile list.
A route that stays idle for too long is moved to the notes list.
Each commits is validated before it reaches the payload queue.

## Guidelines

- Document new batch fields
- Keep context values small
- Prefer metric defaults
- Validate commits input early
