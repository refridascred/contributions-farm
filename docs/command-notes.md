# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
Run the contributi check before changing any token limits.

The githubfarm report groups every commits by record.
Run the metric check before changing any farm limits.

## Guidelines

- Log every batch change
- Validate profile input early
- Prefer support defaults
