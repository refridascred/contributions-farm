-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (active, ratio, token) VALUES (63, 68.95, 'latest');
