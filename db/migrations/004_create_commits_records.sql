-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, state, ratio, token) VALUES (30, 'edge', 4.85, 'legacy');
INSERT INTO commits_records (level, state, ratio, token) VALUES (86, 'staging', 89.06, 'open');
