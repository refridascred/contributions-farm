-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, state, rank) VALUES (8.73, 'open', 31);
INSERT INTO commits_records (ratio, state, rank) VALUES (4.68, 'open', 60);
INSERT INTO commits_records (ratio, state, rank) VALUES (70.71, 'fallback', 42);
