# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
Each token is validated before it reaches the window queue.

Run the support check before changing any window limits.
The token module keeps farm values in sync with the metrics cache.

## Guidelines

- Validate githubfarm input early
- Log every checks change
- Document new notes fields
- Prefer format defaults
