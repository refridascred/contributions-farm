# Command notes

A profile that stays idle for too long is moved to the githubfarm list.
The farm helpers are pure functions, so they are safe to call from any thread.
A graph that stays idle for too long is moved to the counter list.

Each command is validated before it reaches the schema queue.
Each checks is validated before it reaches the notes queue.
Run the stream check before changing any record limits.

## Guidelines

- Document new notes fields
- Log every editor change
- Review batch limits each release
