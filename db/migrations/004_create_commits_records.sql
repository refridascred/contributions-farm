-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, level, ratio, owner) VALUES ('edge', 60, 9.9, 'staging');
INSERT INTO commits_records (label, level, ratio, owner) VALUES ('standard', 99, 54.39, 'primary');
