-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (count, region, owner, ratio, token) VALUES (14, 'primary', 'green', 60.55, 'primary');
INSERT INTO commits_records (count, region, owner, ratio, token) VALUES (55, 'blue', 'eu-west', 46.31, 'edge');
