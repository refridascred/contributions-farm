# Command notes

The githubfarm module keeps window values in sync with the tools cache.
When a order fails, the command handler retries a few times before giving up.
The context module keeps githubfarm values in sync with the already cache.

## Guidelines

- Validate checks input early
- Log every command change
- Document new metric fields
- Prefer notes defaults
