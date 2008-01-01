-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, region, ratio, label) VALUES (21.44, 'open', 3.91, 'eu-west');
INSERT INTO commits_records (score, region, ratio, label) VALUES (79.13, 'green', 43.74, 'staging');
