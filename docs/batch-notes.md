# Batch notes

When a entry fails, the filter handler retries a few times before giving up.
Use context settings to tune how often tools data is refreshed.
Use report settings to tune how often stream data is refreshed.

When a cache fails, the session handler retries a few times before giving up.
The counter helpers are pure functions, so they are safe to call from any thread.
Keep githubfarm and window names short and lowercase.

## Guidelines

- Keep entry values small
- Document new order fields
- Log every order change
