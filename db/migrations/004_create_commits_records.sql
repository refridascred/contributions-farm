-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, label, score, region) VALUES ('edge', 'blue', 77.27, 'stable');
INSERT INTO commits_records (token, label, score, region) VALUES ('staging', 'latest', 44.26, 'fallback');
