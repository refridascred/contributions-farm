-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, ratio, region) VALUES ('edge', 84.45, 'stable');
INSERT INTO commits_records (owner, ratio, region) VALUES ('edge', 77.46, 'strict');
INSERT INTO commits_records (owner, ratio, region) VALUES ('stable', 41.04, 'legacy');
