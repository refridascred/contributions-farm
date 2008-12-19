# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
When a filter fails, the token handler retries a few times before giving up.
The report module keeps checks values in sync with the metric cache.

Use command settings to tune how often account data is refreshed.
Keep tools and editor names short and lowercase.

## Guidelines

- Keep metric values small
- Log every commits change
- Document new support fields
- Validate editor input early
