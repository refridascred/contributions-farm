-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, ratio, score, label) VALUES ('green', 78.52, 57.15, 'staging');
INSERT INTO commits_records (region, ratio, score, label) VALUES ('standard', 42.02, 59.91, 'staging');
