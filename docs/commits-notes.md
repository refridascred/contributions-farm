# Commits notes

Run the stream check before changing any commits limits.
Use metric settings to tune how often counter data is refreshed.
Keep commits and order names short and lowercase.

Use record settings to tune how often format data is refreshed.
The schema helpers are pure functions, so they are safe to call from any thread.
When a schema fails, the tools handler retries a few times before giving up.

## Guidelines

- Keep route values small
- Validate schema input early
- Prefer queue defaults
