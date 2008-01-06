# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
Each token is validated before it reaches the format queue.
Keep queue and batches names short and lowercase.

The window report groups every commits by session.
A contributi that stays idle for too long is moved to the checks list.

## Guidelines

- Validate githubfarm input early
- Log every context change
- Review metrics limits each release
