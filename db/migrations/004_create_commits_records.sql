-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (owner, region, ratio, rank, count) VALUES ('latest', 'staging', 59.15, 32, 0);
INSERT INTO commits_records (owner, region, ratio, rank, count) VALUES ('fallback', 'eu-west', 76.15, 26, 14);
