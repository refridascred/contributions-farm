# Command notes

Use record settings to tune how often format data is refreshed.
Each commits is validated before it reaches the profile queue.
The support helpers are pure functions, so they are safe to call from any thread.

A metrics that stays idle for too long is moved to the githubfarm list.
Keep support and commits names short and lowercase.
Defaults for notes live in the config folder and can be overridden per environment.

## Guidelines

- Log every profile change
- Review schema limits each release
- Prefer cache defaults
- Keep notes values small
