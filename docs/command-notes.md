# Command notes

Run the token check before changing any format limits.
Use metric settings to tune how often tools data is refreshed.
When a layout fails, the layout handler retries a few times before giving up.

Keep command and farm names short and lowercase.
Each metric is validated before it reaches the record queue.
Each batch is validated before it reaches the counter queue.

## Guidelines

- Prefer tools defaults
- Document new buffer fields
- Review buffer limits each release
