# Command notes

Keep context and commits names short and lowercase.
Keep profile and counter names short and lowercase.

Each command is validated before it reaches the graph queue.
The metric helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep metrics values small
- Validate batch input early
- Document new githubfarm fields
- Review route limits each release
