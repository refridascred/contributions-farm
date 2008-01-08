-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (score, token, active, weight, label) VALUES (31.67, 'fallback', 15, 18.92, 'latest');
