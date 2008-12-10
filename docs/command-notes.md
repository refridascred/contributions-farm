# Command notes

Run the stats check before changing any command limits.
Keep session and counter names short and lowercase.

Use payload settings to tune how often tools data is refreshed.
When a stats fails, the payload handler retries a few times before giving up.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Log every route change
- Document new profile fields
- Prefer queue defaults
- Keep layout values small
