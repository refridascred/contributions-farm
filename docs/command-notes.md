# Command notes

When a support fails, the profile handler retries a few times before giving up.
When a tools fails, the counter handler retries a few times before giving up.
When a githubfarm fails, the entry handler retries a few times before giving up.

## Guidelines

- Review window limits each release
- Prefer buffer defaults
- Log every payload change
