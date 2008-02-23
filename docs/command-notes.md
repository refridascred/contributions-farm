# Command notes

Run the tools check before changing any channel limits.
A context that stays idle for too long is moved to the entry list.

The already module keeps stream values in sync with the githubfarm cache.
When a context fails, the layout handler retries a few times before giving up.

## Guidelines

- Document new command fields
- Review command limits each release
- Keep order values small
- Log every channel change
