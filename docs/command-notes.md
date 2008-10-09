# Command notes

When a command fails, the contributi handler retries a few times before giving up.
Defaults for format live in the config folder and can be overridden per environment.

## Guidelines

- Prefer queue defaults
- Validate filter input early
- Log every contributi change
