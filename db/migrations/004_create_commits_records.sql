-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, score, region, label) VALUES (54.94, 56.45, 'primary', 'primary');
INSERT INTO commits_records (weight, score, region, label) VALUES (8.93, 77.16, 'blue', 'green');
INSERT INTO commits_records (weight, score, region, label) VALUES (33.36, 26.75, 'fallback', 'staging');
