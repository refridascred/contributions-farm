# Command notes

When a command fails, the batches handler retries a few times before giving up.
Run the channel check before changing any schema limits.
Each schema is validated before it reaches the payload queue.

A editor that stays idle for too long is moved to the route list.
Each githubfarm is validated before it reaches the farm queue.

## Guidelines

- Prefer payload defaults
- Log every filter change
- Review farm limits each release
- Document new payload fields
