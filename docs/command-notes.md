# Command notes

Keep cache and format names short and lowercase.
When a tools fails, the schema handler retries a few times before giving up.

Defaults for record live in the config folder and can be overridden per environment.
Each route is validated before it reaches the counter queue.
Use cache settings to tune how often stream data is refreshed.

## Guidelines

- Log every schema change
- Validate profile input early
- Document new record fields
