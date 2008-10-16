# Command notes

When a token fails, the record handler retries a few times before giving up.
Run the entry check before changing any graph limits.
When a githubfarm fails, the graph handler retries a few times before giving up.

## Guidelines

- Validate counter input early
- Log every filter change
- Review session limits each release
