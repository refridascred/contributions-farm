-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, label, token) VALUES (33.37, 'edge', 'blue');
INSERT INTO commits_records (score, label, token) VALUES (44.15, 'standard', 'edge');
INSERT INTO commits_records (score, label, token) VALUES (0.71, 'open', 'legacy');
