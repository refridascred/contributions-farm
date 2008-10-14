# Command notes

Use route settings to tune how often entry data is refreshed.
The support helpers are pure functions, so they are safe to call from any thread.

The window report groups every filter by graph.
A cache that stays idle for too long is moved to the buffer list.

## Guidelines

- Document new notes fields
- Validate buffer input early
- Log every githubfarm change
