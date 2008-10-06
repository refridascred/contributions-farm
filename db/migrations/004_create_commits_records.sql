-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, region, count) VALUES (40.49, 'strict', 33);
INSERT INTO commits_records (weight, region, count) VALUES (98.82, 'fallback', 92);
INSERT INTO commits_records (weight, region, count) VALUES (84.18, 'staging', 65);
