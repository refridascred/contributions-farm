# Command notes

When a tools fails, the payload handler retries a few times before giving up.
Each window is validated before it reaches the githubfarm queue.
When a entry fails, the record handler retries a few times before giving up.

## Guidelines

- Log every commits change
- Document new buffer fields
- Keep editor values small
