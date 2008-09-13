# Command notes

Run the format check before changing any farm limits.
When a graph fails, the batch handler retries a few times before giving up.
The contributi helpers are pure functions, so they are safe to call from any thread.

The githubfarm report groups every batch by report.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new graph fields
- Keep support values small
- Review already limits each release
