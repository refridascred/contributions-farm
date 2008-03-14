# Command notes

Use profile settings to tune how often order data is refreshed.
The schema helpers are pure functions, so they are safe to call from any thread.

When a stats fails, the graph handler retries a few times before giving up.
Keep report and editor names short and lowercase.

## Guidelines

- Log every batches change
- Keep filter values small
- Validate entry input early
- Review layout limits each release
