# Command notes

Run the checks check before changing any editor limits.
A tools that stays idle for too long is moved to the checks list.
The filter helpers are pure functions, so they are safe to call from any thread.

Use command settings to tune how often graph data is refreshed.
Use queue settings to tune how often channel data is refreshed.
Use githubfarm settings to tune how often layout data is refreshed.

## Guidelines

- Log every batches change
- Keep cache values small
- Document new metric fields
