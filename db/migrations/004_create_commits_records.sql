-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (rank, count, ratio, token, region) VALUES (31, 47, 61.93, 'cached', 'fallback');
INSERT INTO commits_records (rank, count, ratio, token, region) VALUES (81, 91, 44.52, 'cached', 'standard');
