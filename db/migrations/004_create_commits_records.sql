-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, ratio, active, count) VALUES ('primary', 34.03, 13, 98);
