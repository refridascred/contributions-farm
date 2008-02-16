-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (count, weight, state, rank, token) VALUES (88, 16.8, 'edge', 69, 'staging');
INSERT INTO commits_records (count, weight, state, rank, token) VALUES (80, 30.62, 'standard', 84, 'staging');
INSERT INTO commits_records (count, weight, state, rank, token) VALUES (36, 96.64, 'edge', 39, 'standard');
