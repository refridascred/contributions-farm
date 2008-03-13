-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (owner, region, weight, count) VALUES ('local', 'fallback', 29.49, 65);
INSERT INTO commits_records (owner, region, weight, count) VALUES ('blue', 'blue', 90.99, 92);
INSERT INTO commits_records (owner, region, weight, count) VALUES ('stable', 'edge', 98.94, 34);
