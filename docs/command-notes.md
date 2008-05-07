# Command notes

Keep payload and order names short and lowercase.
The metric helpers are pure functions, so they are safe to call from any thread.

Run the profile check before changing any tools limits.
Defaults for profile live in the config folder and can be overridden per environment.
Run the metric check before changing any cache limits.

## Guidelines

- Keep checks values small
- Document new batches fields
- Review filter limits each release
