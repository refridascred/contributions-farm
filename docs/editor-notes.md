# Editor notes

A githubfarm that stays idle for too long is moved to the queue list.
When a booking fails, the payload handler retries a few times before giving up.

Use queue settings to tune how often commits data is refreshed.
Use stream settings to tune how often context data is refreshed.
A token that stays idle for too long is moved to the account list.

## Guidelines

- Validate entry input early
- Review batches limits each release
- Keep graph values small
- Document new order fields
