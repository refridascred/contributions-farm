# Command notes

A token that stays idle for too long is moved to the context list.
When a counter fails, the record handler retries a few times before giving up.

## Guidelines

- Keep githubfarm values small
- Log every batch change
- Document new buffer fields
