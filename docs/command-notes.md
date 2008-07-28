# Command notes

When a layout fails, the layout handler retries a few times before giving up.
A githubfarm that stays idle for too long is moved to the checks list.
The account helpers are pure functions, so they are safe to call from any thread.

When a format fails, the notes handler retries a few times before giving up.
A payload that stays idle for too long is moved to the cluster list.

## Guidelines

- Log every githubfarm change
- Document new tools fields
- Validate githubfarm input early
