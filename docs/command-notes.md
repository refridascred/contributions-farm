# Command notes

Use layout settings to tune how often record data is refreshed.
Use window settings to tune how often entry data is refreshed.
When a buffer fails, the account handler retries a few times before giving up.

The filter report groups every queue by account.
The commits helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every support change
- Document new layout fields
- Validate batches input early
