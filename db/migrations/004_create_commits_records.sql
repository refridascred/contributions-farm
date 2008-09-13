-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, region, weight, score) VALUES ('standard', 'staging', 85.18, 81.86);
INSERT INTO commits_records (label, region, weight, score) VALUES ('green', 'green', 36.76, 64.4);
INSERT INTO commits_records (label, region, weight, score) VALUES ('blue', 'primary', 16.48, 6.36);
