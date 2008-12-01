-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, state, rank, label) VALUES (9.69, 'staging', 19, 'edge');
