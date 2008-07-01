# Command notes

A command that stays idle for too long is moved to the window list.
Run the batch check before changing any record limits.
Each token is validated before it reaches the stream queue.

The payload module keeps profile values in sync with the githubfarm cache.
Use stream settings to tune how often tools data is refreshed.

## Guidelines

- Log every metric change
- Prefer checks defaults
- Keep metrics values small
- Document new githubfarm fields
