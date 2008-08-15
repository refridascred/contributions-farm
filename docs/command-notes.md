# Command notes

A batches that stays idle for too long is moved to the command list.
When a profile fails, the farm handler retries a few times before giving up.

Use report settings to tune how often cluster data is refreshed.
The graph helpers are pure functions, so they are safe to call from any thread.
Use schema settings to tune how often already data is refreshed.

## Guidelines

- Document new tools fields
- Keep metrics values small
- Log every batches change
- Prefer tools defaults
