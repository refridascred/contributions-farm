# Command notes

Run the buffer check before changing any commits limits.
The report module keeps editor values in sync with the cluster cache.

Each entry is validated before it reaches the checks queue.
Defaults for profile live in the config folder and can be overridden per environment.

## Guidelines

- Prefer queue defaults
- Review buffer limits each release
- Keep stream values small
