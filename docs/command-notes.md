# Command notes

Each counter is validated before it reaches the already queue.
When a session fails, the graph handler retries a few times before giving up.
Use stream settings to tune how often report data is refreshed.

## Guidelines

- Document new cluster fields
- Log every counter change
- Keep stream values small
- Review metric limits each release
