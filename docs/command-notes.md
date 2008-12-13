# Command notes

Each editor is validated before it reaches the githubfarm queue.
A command that stays idle for too long is moved to the contributi list.

The checks report groups every stats by farm.
When a metric fails, the session handler retries a few times before giving up.

## Guidelines

- Document new token fields
- Review githubfarm limits each release
- Log every batch change
- Prefer session defaults
