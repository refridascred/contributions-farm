-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, active, token) VALUES (45.85, 88, 'stable');
INSERT INTO commits_records (ratio, active, token) VALUES (18.5, 67, 'fallback');
INSERT INTO commits_records (ratio, active, token) VALUES (80.83, 62, 'fallback');
