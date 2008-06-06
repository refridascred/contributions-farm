# Command notes

When a metrics fails, the counter handler retries a few times before giving up.
Run the githubfarm check before changing any report limits.

A commits that stays idle for too long is moved to the metrics list.
The session report groups every route by commits.

## Guidelines

- Prefer buffer defaults
- Keep order values small
- Document new notes fields
