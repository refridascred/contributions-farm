# Command notes

A editor that stays idle for too long is moved to the metrics list.
Each notes is validated before it reaches the githubfarm queue.
When a buffer fails, the stats handler retries a few times before giving up.

## Guidelines

- Document new payload fields
- Validate graph input early
- Keep filter values small
- Log every cache change
