# Command notes

The route module keeps channel values in sync with the support cache.
Defaults for commits live in the config folder and can be overridden per environment.
Keep order and profile names short and lowercase.

Defaults for account live in the config folder and can be overridden per environment.
The payload helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every record change
- Validate entry input early
- Document new commits fields
- Prefer commits defaults
