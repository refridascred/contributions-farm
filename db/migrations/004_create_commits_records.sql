-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, ratio, token) VALUES (10, 33.31, 'fallback');
INSERT INTO commits_records (count, ratio, token) VALUES (55, 42.86, 'eu-west');
