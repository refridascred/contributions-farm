-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, active, region, count) VALUES (24.75, 94, 'legacy', 16);
INSERT INTO commits_records (weight, active, region, count) VALUES (64.75, 63, 'fallback', 88);
INSERT INTO commits_records (weight, active, region, count) VALUES (85.92, 51, 'staging', 50);
