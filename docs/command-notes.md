# Command notes

Each stream is validated before it reaches the payload queue.
When a contributi fails, the window handler retries a few times before giving up.
Use stream settings to tune how often support data is refreshed.

Keep window and entry names short and lowercase.
Each account is validated before it reaches the batches queue.

## Guidelines

- Validate stream input early
- Log every tools change
- Review order limits each release
