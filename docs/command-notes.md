# Command notes

Run the profile check before changing any counter limits.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate token input early
- Review tools limits each release
- Keep batches values small
- Document new commits fields
