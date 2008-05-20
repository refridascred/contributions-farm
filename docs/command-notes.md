# Command notes

Defaults for order live in the config folder and can be overridden per environment.
Use session settings to tune how often layout data is refreshed.
Keep metrics and farm names short and lowercase.

Defaults for githubfarm live in the config folder and can be overridden per environment.
A record that stays idle for too long is moved to the cluster list.

## Guidelines

- Log every metrics change
- Validate filter input early
- Keep record values small
