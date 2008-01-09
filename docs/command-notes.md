# Command notes

When a cluster fails, the commits handler retries a few times before giving up.
When a githubfarm fails, the token handler retries a few times before giving up.

## Guidelines

- Keep payload values small
- Prefer queue defaults
- Document new metric fields
- Review batch limits each release
