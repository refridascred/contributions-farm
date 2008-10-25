# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
A contributi that stays idle for too long is moved to the schema list.
Each githubfarm is validated before it reaches the tools queue.

Each commits is validated before it reaches the cluster queue.
The batch report groups every metric by editor.

## Guidelines

- Log every report change
- Validate tools input early
- Keep window values small
