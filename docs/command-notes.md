# Command notes

When a githubfarm fails, the graph handler retries a few times before giving up.
When a commits fails, the checks handler retries a few times before giving up.

## Guidelines

- Prefer cache defaults
- Keep record values small
- Review queue limits each release
- Validate cache input early
