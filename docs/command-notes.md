# Command notes

Run the notes check before changing any cluster limits.
Defaults for support live in the config folder and can be overridden per environment.
The command module keeps schema values in sync with the editor cache.

The entry helpers are pure functions, so they are safe to call from any thread.
Keep window and stream names short and lowercase.
Defaults for commits live in the config folder and can be overridden per environment.

## Guidelines

- Review context limits each release
- Log every account change
- Validate context input early
