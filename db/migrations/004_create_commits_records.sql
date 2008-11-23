-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, count, ratio, token, owner) VALUES ('fallback', 25, 0.41, 'green', 'eu-west');
INSERT INTO commits_records (region, count, ratio, token, owner) VALUES ('staging', 53, 2.45, 'edge', 'local');
