# Command notes

Run the profile check before changing any order limits.
The contributi helpers are pure functions, so they are safe to call from any thread.

The batches module keeps support values in sync with the stream cache.
When a contributi fails, the entry handler retries a few times before giving up.

## Guidelines

- Log every format change
- Document new token fields
- Review command limits each release
