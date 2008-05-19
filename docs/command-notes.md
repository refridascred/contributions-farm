# Command notes

When a layout fails, the format handler retries a few times before giving up.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new checks fields
- Review githubfarm limits each release
- Validate format input early
- Prefer cache defaults
