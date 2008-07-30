# Command notes

When a commits fails, the metric handler retries a few times before giving up.
Each graph is validated before it reaches the account queue.

When a graph fails, the format handler retries a few times before giving up.
Use schema settings to tune how often support data is refreshed.

## Guidelines

- Keep filter values small
- Log every farm change
- Document new buffer fields
- Review token limits each release
