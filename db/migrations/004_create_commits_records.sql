-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, count, region, active) VALUES (7.96, 44, 'local', 39);
INSERT INTO commits_records (ratio, count, region, active) VALUES (98.88, 72, 'primary', 26);
INSERT INTO commits_records (ratio, count, region, active) VALUES (12.56, 36, 'blue', 18);
