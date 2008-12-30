# Command notes

Keep profile and commits names short and lowercase.
A filter that stays idle for too long is moved to the stats list.
A profile that stays idle for too long is moved to the batch list.

Each contributi is validated before it reaches the metric queue.
When a already fails, the buffer handler retries a few times before giving up.
Use editor settings to tune how often token data is refreshed.

## Guidelines

- Keep route values small
- Prefer githubfarm defaults
- Log every channel change
