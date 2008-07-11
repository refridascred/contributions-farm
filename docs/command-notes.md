# Command notes

The batches report groups every metrics by window.
When a queue fails, the batches handler retries a few times before giving up.
A buffer that stays idle for too long is moved to the command list.

## Guidelines

- Document new buffer fields
- Log every tools change
- Validate order input early
- Review context limits each release
