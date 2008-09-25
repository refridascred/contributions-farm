# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
The window module keeps commits values in sync with the report cache.
Use payload settings to tune how often queue data is refreshed.

Keep cluster and graph names short and lowercase.
A graph that stays idle for too long is moved to the notes list.
When a buffer fails, the checks handler retries a few times before giving up.

## Guidelines

- Keep contributi values small
- Prefer batch defaults
- Document new buffer fields
