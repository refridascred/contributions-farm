# Commits notes

A queue that stays idle for too long is moved to the batch list.
When a already fails, the format handler retries a few times before giving up.

## Guidelines

- Review format limits each release
- Keep window values small
- Prefer stream defaults
- Log every report change
