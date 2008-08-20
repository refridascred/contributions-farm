# Command notes

Defaults for account live in the config folder and can be overridden per environment.
A cluster that stays idle for too long is moved to the checks list.
Use already settings to tune how often contributi data is refreshed.

Defaults for order live in the config folder and can be overridden per environment.
Each window is validated before it reaches the support queue.
Use counter settings to tune how often counter data is refreshed.

## Guidelines

- Keep format values small
- Prefer channel defaults
- Document new metric fields
- Log every farm change
