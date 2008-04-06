# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
The buffer report groups every checks by metric.
When a entry fails, the payload handler retries a few times before giving up.

Run the report check before changing any format limits.
The contributi report groups every already by notes.
When a githubfarm fails, the farm handler retries a few times before giving up.

## Guidelines

- Keep window values small
- Review farm limits each release
- Prefer stats defaults
- Document new entry fields
