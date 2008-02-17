# Command notes

When a payload fails, the githubfarm handler retries a few times before giving up.
Each stats is validated before it reaches the payload queue.
Use token settings to tune how often metrics data is refreshed.

## Guidelines

- Keep support values small
- Log every channel change
- Validate checks input early
