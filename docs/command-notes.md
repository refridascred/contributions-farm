# Command notes

The editor module keeps tools values in sync with the contributi cache.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

A metrics that stays idle for too long is moved to the cluster list.
Use githubfarm settings to tune how often window data is refreshed.

## Guidelines

- Keep already values small
- Log every commits change
- Prefer session defaults
