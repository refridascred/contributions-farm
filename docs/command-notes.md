# Command notes

Keep payload and report names short and lowercase.
The support report groups every record by counter.

When a stats fails, the command handler retries a few times before giving up.
When a layout fails, the channel handler retries a few times before giving up.

## Guidelines

- Keep githubfarm values small
- Validate batches input early
- Log every tools change
