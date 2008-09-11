-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, active) VALUES (43.9, 51);
INSERT INTO commits_records (ratio, active) VALUES (11.16, 29);
INSERT INTO commits_records (ratio, active) VALUES (62.38, 47);
