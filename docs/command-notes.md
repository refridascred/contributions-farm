# Command notes

Run the profile check before changing any stats limits.
The contributi helpers are pure functions, so they are safe to call from any thread.

Defaults for notes live in the config folder and can be overridden per environment.
Keep graph and record names short and lowercase.
Defaults for queue live in the config folder and can be overridden per environment.

## Guidelines

- Review checks limits each release
- Prefer checks defaults
- Log every githubfarm change
- Keep payload values small
