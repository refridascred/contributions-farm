# Command notes

Run the graph check before changing any stream limits.
Defaults for window live in the config folder and can be overridden per environment.
Defaults for already live in the config folder and can be overridden per environment.

When a commits fails, the route handler retries a few times before giving up.
A graph that stays idle for too long is moved to the token list.
Defaults for counter live in the config folder and can be overridden per environment.

## Guidelines

- Review commits limits each release
- Validate channel input early
- Prefer metric defaults
- Keep commits values small
