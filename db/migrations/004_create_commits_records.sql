-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (ratio, region, label, count, active) VALUES (5.48, 'open', 'edge', 30, 32);
INSERT INTO commits_records (ratio, region, label, count, active) VALUES (14.84, 'green', 'cached', 17, 8);
