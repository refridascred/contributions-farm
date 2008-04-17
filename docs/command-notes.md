# Command notes

Run the schema check before changing any command limits.
A stream that stays idle for too long is moved to the checks list.
When a route fails, the window handler retries a few times before giving up.

A farm that stays idle for too long is moved to the metrics list.
When a filter fails, the command handler retries a few times before giving up.

## Guidelines

- Validate counter input early
- Document new already fields
- Log every route change
- Review channel limits each release
