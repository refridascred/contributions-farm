-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, ratio, token) VALUES (40, 60.08, 'cached');
INSERT INTO commits_records (count, ratio, token) VALUES (80, 67.53, 'stable');
INSERT INTO commits_records (count, ratio, token) VALUES (53, 77.49, 'local');
