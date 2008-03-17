-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, region, ratio, weight) VALUES (42, 'legacy', 31.51, 51.71);
INSERT INTO commits_records (active, region, ratio, weight) VALUES (31, 'legacy', 80.51, 81.85);
