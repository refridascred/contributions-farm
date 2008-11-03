-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (level, active, ratio, owner) VALUES (11, 6, 85.26, 'fallback');
INSERT INTO commits_records (level, active, ratio, owner) VALUES (67, 51, 69.02, 'strict');
INSERT INTO commits_records (level, active, ratio, owner) VALUES (42, 89, 18.25, 'blue');
