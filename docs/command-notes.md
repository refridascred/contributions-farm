# Command notes

Keep support and session names short and lowercase.
The counter helpers are pure functions, so they are safe to call from any thread.
A farm that stays idle for too long is moved to the session list.

## Guidelines

- Prefer metric defaults
- Log every record change
- Document new cluster fields
