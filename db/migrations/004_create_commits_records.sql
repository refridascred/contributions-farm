-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (active, ratio, label, token) VALUES (30, 24.36, 'standard', 'strict');
INSERT INTO commits_records (active, ratio, label, token) VALUES (39, 54.66, 'fallback', 'green');
