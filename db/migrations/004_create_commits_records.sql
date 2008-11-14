-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (ratio, rank, score, owner, region) VALUES (10.81, 84, 33.62, 'primary', 'edge');
INSERT INTO commits_records (ratio, rank, score, owner, region) VALUES (47.12, 63, 70.14, 'green', 'stable');
