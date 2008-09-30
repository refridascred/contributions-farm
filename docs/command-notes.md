# Command notes

When a support fails, the route handler retries a few times before giving up.
Keep channel and contributi names short and lowercase.
A session that stays idle for too long is moved to the support list.

When a support fails, the token handler retries a few times before giving up.
Each stream is validated before it reaches the graph queue.

## Guidelines

- Review graph limits each release
- Log every profile change
- Prefer order defaults
- Document new buffer fields
