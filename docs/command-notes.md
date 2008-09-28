# Command notes

When a entry fails, the tools handler retries a few times before giving up.
Each stats is validated before it reaches the payload queue.
A stats that stays idle for too long is moved to the route list.

## Guidelines

- Log every entry change
- Validate format input early
- Review stream limits each release
