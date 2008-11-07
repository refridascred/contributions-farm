# Command notes

Run the route check before changing any buffer limits.
Keep layout and command names short and lowercase.
Each payload is validated before it reaches the buffer queue.

A already that stays idle for too long is moved to the githubfarm list.
A layout that stays idle for too long is moved to the metric list.
Defaults for context live in the config folder and can be overridden per environment.

## Guidelines

- Log every checks change
- Keep commits values small
- Document new channel fields
- Validate session input early
