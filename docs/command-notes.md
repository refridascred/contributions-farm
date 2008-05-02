# Command notes

Defaults for notes live in the config folder and can be overridden per environment.
Each stats is validated before it reaches the graph queue.

Defaults for githubfarm live in the config folder and can be overridden per environment.
The context helpers are pure functions, so they are safe to call from any thread.
The tools helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep already values small
- Document new stats fields
- Review profile limits each release
- Log every token change
