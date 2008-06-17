# Command notes

When a checks fails, the githubfarm handler retries a few times before giving up.
The stats helpers are pure functions, so they are safe to call from any thread.

The session report groups every notes by report.
Keep buffer and contributi names short and lowercase.
A stats that stays idle for too long is moved to the layout list.

## Guidelines

- Document new counter fields
- Keep entry values small
- Validate githubfarm input early
