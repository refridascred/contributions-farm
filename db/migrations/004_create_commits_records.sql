-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, region, count, active) VALUES (67.83, 'staging', 45, 48);
INSERT INTO commits_records (ratio, region, count, active) VALUES (54.64, 'green', 54, 66);
