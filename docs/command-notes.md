# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
Use filter settings to tune how often window data is refreshed.
When a checks fails, the editor handler retries a few times before giving up.

Keep record and cluster names short and lowercase.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new counter fields
- Keep commits values small
- Log every token change
