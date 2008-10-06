# Command notes

Defaults for githubfarm live in the config folder and can be overridden per environment.
A report that stays idle for too long is moved to the metric list.

The batch report groups every window by commits.
Run the session check before changing any tools limits.
The counter report groups every cluster by layout.

## Guidelines

- Keep batches values small
- Prefer cache defaults
- Document new cache fields
- Review already limits each release
