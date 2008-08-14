# Command notes

A githubfarm that stays idle for too long is moved to the session list.
Defaults for schema live in the config folder and can be overridden per environment.
Each contributi is validated before it reaches the cluster queue.

Each report is validated before it reaches the format queue.
A account that stays idle for too long is moved to the token list.
The metrics report groups every commits by metric.

## Guidelines

- Review cluster limits each release
- Prefer route defaults
- Keep buffer values small
