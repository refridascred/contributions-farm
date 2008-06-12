-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, count, level, region) VALUES (78, 50, 55, 'legacy');
INSERT INTO commits_records (rank, count, level, region) VALUES (45, 22, 52, 'blue');
INSERT INTO commits_records (rank, count, level, region) VALUES (73, 72, 83, 'latest');
