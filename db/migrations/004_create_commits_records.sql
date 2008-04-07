-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (score, state, weight, region) VALUES (2.81, 'staging', 29.5, 'edge');
INSERT INTO commits_records (score, state, weight, region) VALUES (3.45, 'edge', 6.06, 'green');
