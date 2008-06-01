# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
The cluster helpers are pure functions, so they are safe to call from any thread.
A entry that stays idle for too long is moved to the metric list.

Keep editor and graph names short and lowercase.
The entry helpers are pure functions, so they are safe to call from any thread.
The checks report groups every cluster by session.

## Guidelines

- Validate stats input early
- Keep report values small
- Document new stream fields
- Review farm limits each release
