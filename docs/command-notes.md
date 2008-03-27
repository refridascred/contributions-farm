# Command notes

When a checks fails, the filter handler retries a few times before giving up.
Run the graph check before changing any cache limits.
Run the entry check before changing any githubfarm limits.

## Guidelines

- Log every format change
- Review tools limits each release
- Validate githubfarm input early
- Keep buffer values small
