# Command notes

Keep filter and cluster names short and lowercase.
Defaults for notes live in the config folder and can be overridden per environment.

The route helpers are pure functions, so they are safe to call from any thread.
Run the profile check before changing any stream limits.
A report that stays idle for too long is moved to the layout list.

## Guidelines

- Log every checks change
- Review token limits each release
- Validate account input early
