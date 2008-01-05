# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
A report that stays idle for too long is moved to the session list.

## Guidelines

- Document new checks fields
- Review session limits each release
- Log every counter change
- Keep notes values small
