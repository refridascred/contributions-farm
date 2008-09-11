# Command notes

Run the schema check before changing any route limits.
Each report is validated before it reaches the schema queue.
Keep filter and route names short and lowercase.

Keep format and command names short and lowercase.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep already values small
- Validate farm input early
- Review buffer limits each release
