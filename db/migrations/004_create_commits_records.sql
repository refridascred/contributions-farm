-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (level, ratio, active) VALUES (82, 13.87, 13);
INSERT INTO commits_records (level, ratio, active) VALUES (23, 63.73, 66);
