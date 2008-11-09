# Command notes

Run the notes check before changing any order limits.
The commits module keeps notes values in sync with the batch cache.
When a schema fails, the window handler retries a few times before giving up.

## Guidelines

- Validate queue input early
- Review format limits each release
- Log every window change
