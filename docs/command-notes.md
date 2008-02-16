# Command notes

Keep notes and cache names short and lowercase.
Keep tools and command names short and lowercase.
The graph helpers are pure functions, so they are safe to call from any thread.

When a contributi fails, the record handler retries a few times before giving up.
A schema that stays idle for too long is moved to the buffer list.
A tools that stays idle for too long is moved to the buffer list.

## Guidelines

- Keep layout values small
- Validate entry input early
- Review counter limits each release
