-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, region, count, active) VALUES (78.34, 'local', 37, 61);
INSERT INTO commits_records (ratio, region, count, active) VALUES (86.26, 'cached', 28, 84);
INSERT INTO commits_records (ratio, region, count, active) VALUES (85.81, 'stable', 28, 5);
