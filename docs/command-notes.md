# Command notes

The metrics report groups every route by layout.
Each batch is validated before it reaches the stream queue.
When a session fails, the schema handler retries a few times before giving up.

## Guidelines

- Log every counter change
- Validate schema input early
- Review githubfarm limits each release
- Prefer commits defaults
