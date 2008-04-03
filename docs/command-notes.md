# Command notes

A context that stays idle for too long is moved to the commits list.
The support module keeps stats values in sync with the stats cache.

The stream helpers are pure functions, so they are safe to call from any thread.
Run the contributi check before changing any githubfarm limits.

## Guidelines

- Keep batch values small
- Log every githubfarm change
- Prefer layout defaults
