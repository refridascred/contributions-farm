-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (level, ratio, rank, region) VALUES (79, 68.99, 57, 'fallback');
INSERT INTO commits_records (level, ratio, rank, region) VALUES (30, 11.95, 69, 'open');
