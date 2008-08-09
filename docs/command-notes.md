# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
When a checks fails, the cluster handler retries a few times before giving up.
Each profile is validated before it reaches the payload queue.

When a profile fails, the cluster handler retries a few times before giving up.
Use already settings to tune how often record data is refreshed.

## Guidelines

- Document new tools fields
- Prefer notes defaults
- Validate buffer input early
