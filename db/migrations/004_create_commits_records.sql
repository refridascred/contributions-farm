-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (score, active, state) VALUES (95.53, 39, 'staging');
INSERT INTO commits_records (score, active, state) VALUES (7.47, 31, 'eu-west');
INSERT INTO commits_records (score, active, state) VALUES (80.61, 90, 'strict');
