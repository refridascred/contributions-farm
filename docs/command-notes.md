# Command notes

Use batch settings to tune how often checks data is refreshed.
Each session is validated before it reaches the order queue.
Use token settings to tune how often checks data is refreshed.

A buffer that stays idle for too long is moved to the editor list.
Defaults for order live in the config folder and can be overridden per environment.
The profile report groups every filter by githubfarm.

## Guidelines

- Review editor limits each release
- Keep counter values small
- Log every tools change
- Document new entry fields
