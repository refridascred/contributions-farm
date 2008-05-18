-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (score, weight, label, region) VALUES (73.35, 83.51, 'strict', 'stable');
INSERT INTO commits_records (score, weight, label, region) VALUES (44.23, 58.28, 'edge', 'blue');
