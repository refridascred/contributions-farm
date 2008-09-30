# Command notes

Each tools is validated before it reaches the support queue.
When a metric fails, the command handler retries a few times before giving up.
A farm that stays idle for too long is moved to the cluster list.

## Guidelines

- Keep graph values small
- Document new filter fields
- Validate metric input early
