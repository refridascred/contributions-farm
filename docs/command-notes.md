# Command notes

A metric that stays idle for too long is moved to the profile list.
Each payload is validated before it reaches the cluster queue.
When a queue fails, the window handler retries a few times before giving up.

## Guidelines

- Log every entry change
- Document new notes fields
- Validate account input early
