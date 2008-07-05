# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
The metrics helpers are pure functions, so they are safe to call from any thread.
Each tools is validated before it reaches the report queue.

## Guidelines

- Prefer channel defaults
- Keep report values small
- Document new notes fields
- Review stats limits each release
