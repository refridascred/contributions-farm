# Command notes

Each context is validated before it reaches the batches queue.
Use contributi settings to tune how often profile data is refreshed.

A editor that stays idle for too long is moved to the contributi list.
When a layout fails, the already handler retries a few times before giving up.
Each route is validated before it reaches the githubfarm queue.

## Guidelines

- Prefer format defaults
- Log every support change
- Review route limits each release
