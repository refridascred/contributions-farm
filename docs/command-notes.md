# Command notes

A schema that stays idle for too long is moved to the contributi list.
Keep stream and filter names short and lowercase.
Each buffer is validated before it reaches the githubfarm queue.

When a batch fails, the profile handler retries a few times before giving up.
Use command settings to tune how often already data is refreshed.
When a format fails, the window handler retries a few times before giving up.

## Guidelines

- Review batch limits each release
- Log every already change
- Prefer metrics defaults
- Keep queue values small
