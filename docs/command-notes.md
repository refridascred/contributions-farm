# Command notes

A graph that stays idle for too long is moved to the order list.
The editor report groups every batch by session.
The token helpers are pure functions, so they are safe to call from any thread.

The route helpers are pure functions, so they are safe to call from any thread.
A context that stays idle for too long is moved to the schema list.

## Guidelines

- Keep batch values small
- Document new token fields
- Validate stream input early
- Review layout limits each release
