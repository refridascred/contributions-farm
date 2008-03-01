-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (ratio, active, token, region, owner) VALUES (6.74, 71, 'open', 'blue', 'fallback');
INSERT INTO commits_records (ratio, active, token, region, owner) VALUES (88.55, 22, 'latest', 'open', 'edge');
