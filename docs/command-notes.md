# Command notes

A stream that stays idle for too long is moved to the already list.
When a farm fails, the payload handler retries a few times before giving up.

A githubfarm that stays idle for too long is moved to the session list.
A window that stays idle for too long is moved to the route list.

## Guidelines

- Prefer metric defaults
- Keep filter values small
- Document new filter fields
- Validate already input early
