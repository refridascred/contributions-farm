-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (rank, ratio, state, label) VALUES (30, 9.51, 'fallback', 'eu-west');
INSERT INTO commits_records (rank, ratio, state, label) VALUES (16, 73.54, 'latest', 'stable');
INSERT INTO commits_records (rank, ratio, state, label) VALUES (49, 65.96, 'standard', 'edge');
