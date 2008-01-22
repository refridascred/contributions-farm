# Command notes

When a entry fails, the window handler retries a few times before giving up.
Run the queue check before changing any order limits.
When a record fails, the cache handler retries a few times before giving up.

Keep editor and stream names short and lowercase.
When a profile fails, the account handler retries a few times before giving up.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate metric input early
- Document new route fields
- Log every batches change
