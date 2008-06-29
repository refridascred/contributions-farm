# Command notes

Use queue settings to tune how often schema data is refreshed.
Each commits is validated before it reaches the filter queue.

The counter module keeps notes values in sync with the editor cache.
When a stream fails, the window handler retries a few times before giving up.
Keep githubfarm and context names short and lowercase.

## Guidelines

- Keep session values small
- Prefer account defaults
- Validate profile input early
- Review schema limits each release
