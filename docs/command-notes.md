# Command notes

When a checks fails, the layout handler retries a few times before giving up.
A command that stays idle for too long is moved to the batch list.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep layout values small
- Prefer graph defaults
- Validate commits input early
- Review layout limits each release
