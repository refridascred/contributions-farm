-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, state, active) VALUES (23.85, 'strict', 8);
INSERT INTO commits_records (ratio, state, active) VALUES (74.16, 'latest', 56);
INSERT INTO commits_records (ratio, state, active) VALUES (63.17, 'green', 97);
