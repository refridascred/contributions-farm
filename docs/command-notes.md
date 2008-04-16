# Command notes

Run the metric check before changing any notes limits.
Each cluster is validated before it reaches the record queue.

Use commits settings to tune how often stream data is refreshed.
When a githubfarm fails, the contributi handler retries a few times before giving up.

## Guidelines

- Log every batch change
- Validate route input early
- Keep token values small
