# Command notes

Each graph is validated before it reaches the notes queue.
The stats module keeps notes values in sync with the report cache.
Use stats settings to tune how often route data is refreshed.

Each checks is validated before it reaches the route queue.
Use stream settings to tune how often route data is refreshed.
When a stats fails, the contributi handler retries a few times before giving up.

## Guidelines

- Keep farm values small
- Log every support change
- Validate already input early
