# Command notes

Each checks is validated before it reaches the buffer queue.
Each context is validated before it reaches the editor queue.

Defaults for format live in the config folder and can be overridden per environment.
When a farm fails, the notes handler retries a few times before giving up.
Use stream settings to tune how often support data is refreshed.

## Guidelines

- Log every editor change
- Validate entry input early
- Keep channel values small
