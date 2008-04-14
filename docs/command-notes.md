# Command notes

Each command is validated before it reaches the contributi queue.
The profile report groups every order by batches.
Use report settings to tune how often githubfarm data is refreshed.

The stream report groups every record by graph.
A payload that stays idle for too long is moved to the contributi list.
Each editor is validated before it reaches the record queue.

## Guidelines

- Prefer commits defaults
- Review graph limits each release
- Log every filter change
