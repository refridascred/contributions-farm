# Command notes

When a account fails, the channel handler retries a few times before giving up.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

The stream module keeps route values in sync with the account cache.
Each graph is validated before it reaches the commits queue.
Keep notes and editor names short and lowercase.

## Guidelines

- Log every queue change
- Keep farm values small
- Prefer window defaults
- Validate githubfarm input early
