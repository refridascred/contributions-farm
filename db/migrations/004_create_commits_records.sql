-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, active) VALUES ('standard', 88);
INSERT INTO commits_records (state, active) VALUES ('latest', 55);
INSERT INTO commits_records (state, active) VALUES ('blue', 64);
