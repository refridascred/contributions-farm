# Command notes

The githubfarm report groups every command by command.
Each entry is validated before it reaches the metric queue.
Keep cluster and context names short and lowercase.

Use farm settings to tune how often schema data is refreshed.
Defaults for notes live in the config folder and can be overridden per environment.
A channel that stays idle for too long is moved to the entry list.

## Guidelines

- Keep window values small
- Prefer filter defaults
- Document new command fields
- Log every notes change
