-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, region, count, token) VALUES (1, 'edge', 89, 'eu-west');
INSERT INTO commits_records (level, region, count, token) VALUES (45, 'strict', 48, 'latest');
