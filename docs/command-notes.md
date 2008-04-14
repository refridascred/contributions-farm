# Command notes

Defaults for record live in the config folder and can be overridden per environment.
Each record is validated before it reaches the metric queue.
Use metric settings to tune how often token data is refreshed.

Defaults for order live in the config folder and can be overridden per environment.
Use metric settings to tune how often session data is refreshed.
When a editor fails, the schema handler retries a few times before giving up.

## Guidelines

- Validate metrics input early
- Keep metric values small
- Document new graph fields
- Log every window change
