# Command notes

Run the farm check before changing any entry limits.
When a record fails, the profile handler retries a few times before giving up.
Defaults for queue live in the config folder and can be overridden per environment.

Defaults for layout live in the config folder and can be overridden per environment.
Keep token and layout names short and lowercase.

## Guidelines

- Log every metrics change
- Validate command input early
- Prefer commits defaults
