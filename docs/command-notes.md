# Command notes

Run the cluster check before changing any record limits.
A queue that stays idle for too long is moved to the githubfarm list.

Keep order and route names short and lowercase.
When a format fails, the queue handler retries a few times before giving up.
Each tools is validated before it reaches the notes queue.

## Guidelines

- Prefer githubfarm defaults
- Review contributi limits each release
- Keep channel values small
- Log every notes change
