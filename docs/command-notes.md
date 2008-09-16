# Command notes

Keep counter and counter names short and lowercase.
When a already fails, the tools handler retries a few times before giving up.

The profile report groups every filter by cache.
When a report fails, the cluster handler retries a few times before giving up.
The payload helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer account defaults
- Review report limits each release
- Keep payload values small
- Document new channel fields
