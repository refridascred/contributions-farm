-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (owner, score, rank, state) VALUES ('stable', 0.23, 1, 'fallback');
INSERT INTO commits_records (owner, score, rank, state) VALUES ('fallback', 49.34, 94, 'edge');
INSERT INTO commits_records (owner, score, rank, state) VALUES ('primary', 10.38, 68, 'open');
