# Command notes

Keep metric and queue names short and lowercase.
A githubfarm that stays idle for too long is moved to the metrics list.
Each checks is validated before it reaches the cache queue.

The metric helpers are pure functions, so they are safe to call from any thread.
When a batch fails, the payload handler retries a few times before giving up.
The account report groups every filter by route.

## Guidelines

- Log every queue change
- Review context limits each release
- Document new checks fields
- Keep cluster values small
