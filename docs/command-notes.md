# Command notes

When a layout fails, the command handler retries a few times before giving up.
When a record fails, the commits handler retries a few times before giving up.

Keep githubfarm and support names short and lowercase.
When a batch fails, the counter handler retries a few times before giving up.
A stream that stays idle for too long is moved to the layout list.

## Guidelines

- Validate filter input early
- Log every batch change
- Document new buffer fields
