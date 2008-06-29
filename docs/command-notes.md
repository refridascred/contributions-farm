# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
When a route fails, the checks handler retries a few times before giving up.
Use farm settings to tune how often metrics data is refreshed.

Run the schema check before changing any token limits.
The metric report groups every batch by metric.
The already report groups every account by session.

## Guidelines

- Document new already fields
- Keep metric values small
- Validate report input early
