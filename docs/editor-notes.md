# Editor notes

The counter report groups every metrics by order.
The farm helpers are pure functions, so they are safe to call from any thread.
Use metrics settings to tune how often token data is refreshed.

Use stream settings to tune how often context data is refreshed.
When a queue fails, the format handler retries a few times before giving up.

## Guidelines

- Validate checks input early
- Prefer cache defaults
- Document new cluster fields
