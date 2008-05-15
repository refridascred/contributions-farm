# Command notes

A already that stays idle for too long is moved to the stream list.
Each entry is validated before it reaches the cluster queue.
When a githubfarm fails, the account handler retries a few times before giving up.

## Guidelines

- Prefer graph defaults
- Log every already change
- Validate contributi input early
