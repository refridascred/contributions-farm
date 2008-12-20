-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (ratio, score, active, label) VALUES (49.21, 67.59, 94, 'green');
INSERT INTO commits_records (ratio, score, active, label) VALUES (30.12, 43.96, 12, 'fallback');
