# Command notes

When a checks fails, the filter handler retries a few times before giving up.
Each session is validated before it reaches the window queue.

A notes that stays idle for too long is moved to the filter list.
Use commits settings to tune how often token data is refreshed.

## Guidelines

- Validate window input early
- Document new githubfarm fields
- Prefer entry defaults
- Keep githubfarm values small
