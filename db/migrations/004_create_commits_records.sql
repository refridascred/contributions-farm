-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, score, owner) VALUES ('edge', 83.29, 'edge');
INSERT INTO commits_records (state, score, owner) VALUES ('latest', 59.28, 'green');
INSERT INTO commits_records (state, score, owner) VALUES ('fallback', 71.05, 'legacy');
