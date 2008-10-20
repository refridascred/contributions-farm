# Command notes

Each editor is validated before it reaches the command queue.
Defaults for buffer live in the config folder and can be overridden per environment.
Each filter is validated before it reaches the batches queue.

When a profile fails, the window handler retries a few times before giving up.
Use batch settings to tune how often report data is refreshed.

## Guidelines

- Document new notes fields
- Prefer batches defaults
- Keep context values small
- Log every support change
