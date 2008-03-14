-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, score, token) VALUES ('primary', 69.13, 'primary');
INSERT INTO commits_records (state, score, token) VALUES ('staging', 90.27, 'fallback');
INSERT INTO commits_records (state, score, token) VALUES ('standard', 96.21, 'edge');
