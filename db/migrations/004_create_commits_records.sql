-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, region, label, score) VALUES (60.73, 'latest', 'open', 55.28);
INSERT INTO commits_records (weight, region, label, score) VALUES (8.99, 'latest', 'legacy', 79.21);
