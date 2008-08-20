# Command notes

Run the notes check before changing any format limits.
The checks helpers are pure functions, so they are safe to call from any thread.
Use commits settings to tune how often layout data is refreshed.

The payload report groups every githubfarm by stats.
A stats that stays idle for too long is moved to the channel list.
The graph helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep notes values small
- Log every support change
- Prefer tools defaults
- Validate githubfarm input early
