-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, rank, count, region) VALUES (32.76, 40, 43, 'fallback');
INSERT INTO commits_records (ratio, rank, count, region) VALUES (5.61, 71, 55, 'strict');
INSERT INTO commits_records (ratio, rank, count, region) VALUES (12.21, 34, 67, 'primary');
