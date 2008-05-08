# Command notes

Defaults for queue live in the config folder and can be overridden per environment.
Keep account and metrics names short and lowercase.
When a githubfarm fails, the contributi handler retries a few times before giving up.

Run the layout check before changing any checks limits.
Use token settings to tune how often counter data is refreshed.

## Guidelines

- Prefer filter defaults
- Keep command values small
- Log every farm change
- Document new account fields
