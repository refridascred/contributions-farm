# Command notes

Use filter settings to tune how often route data is refreshed.
A token that stays idle for too long is moved to the farm list.
The metric module keeps token values in sync with the already cache.

Use channel settings to tune how often contributi data is refreshed.
The contributi helpers are pure functions, so they are safe to call from any thread.
Each filter is validated before it reaches the profile queue.

## Guidelines

- Validate buffer input early
- Log every githubfarm change
- Prefer stream defaults
- Review window limits each release
