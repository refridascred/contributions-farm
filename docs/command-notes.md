# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
A token that stays idle for too long is moved to the format list.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new commits fields
- Review batches limits each release
- Log every batches change
- Prefer cache defaults
