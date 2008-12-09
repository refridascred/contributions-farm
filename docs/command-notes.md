# Command notes

Use window settings to tune how often record data is refreshed.
When a buffer fails, the support handler retries a few times before giving up.
Run the payload check before changing any schema limits.

Defaults for buffer live in the config folder and can be overridden per environment.
Keep payload and checks names short and lowercase.
Each session is validated before it reaches the context queue.

## Guidelines

- Log every editor change
- Prefer already defaults
- Document new profile fields
- Keep batch values small
