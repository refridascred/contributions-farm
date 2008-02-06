# Command notes

Run the payload check before changing any order limits.
Run the window check before changing any account limits.

When a record fails, the layout handler retries a few times before giving up.
Each stream is validated before it reaches the metrics queue.
The contributi module keeps account values in sync with the metrics cache.

## Guidelines

- Keep profile values small
- Prefer githubfarm defaults
- Log every tools change
- Document new notes fields
