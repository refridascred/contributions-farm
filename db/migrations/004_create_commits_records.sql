-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (ratio, count, region, label, level) VALUES (95.24, 12, 'strict', 'staging', 83);
INSERT INTO commits_records (ratio, count, region, label, level) VALUES (70.18, 47, 'legacy', 'stable', 78);
