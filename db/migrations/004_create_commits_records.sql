-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, level, score, rank, region) VALUES (96, 71, 1.6, 10, 'legacy');
INSERT INTO commits_records (active, level, score, rank, region) VALUES (25, 15, 85.83, 94, 'latest');
