# Command notes

A commits that stays idle for too long is moved to the checks list.
When a command fails, the queue handler retries a few times before giving up.
Each order is validated before it reaches the graph queue.

## Guidelines

- Validate profile input early
- Document new stream fields
- Review route limits each release
