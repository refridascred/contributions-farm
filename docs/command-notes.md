# Command notes

Run the cache check before changing any profile limits.
Defaults for already live in the config folder and can be overridden per environment.
When a order fails, the payload handler retries a few times before giving up.

Use farm settings to tune how often command data is refreshed.
Each schema is validated before it reaches the batches queue.

## Guidelines

- Log every filter change
- Keep route values small
- Document new entry fields
