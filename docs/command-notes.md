# Command notes

Run the token check before changing any editor limits.
Each layout is validated before it reaches the route queue.
The notes module keeps entry values in sync with the stats cache.

Each channel is validated before it reaches the checks queue.
Use queue settings to tune how often githubfarm data is refreshed.

## Guidelines

- Keep editor values small
- Log every counter change
- Prefer batches defaults
- Document new context fields
