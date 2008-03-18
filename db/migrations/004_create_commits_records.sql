-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (count, ratio, label, region) VALUES (33, 2.65, 'edge', 'green');
INSERT INTO commits_records (count, ratio, label, region) VALUES (30, 12.28, 'strict', 'stable');
