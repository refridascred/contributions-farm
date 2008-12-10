-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, ratio, level, region) VALUES (40, 71.49, 21, 'eu-west');
INSERT INTO commits_records (rank, ratio, level, region) VALUES (43, 8.6, 6, 'fallback');
