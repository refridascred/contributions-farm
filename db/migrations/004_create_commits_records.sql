-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, active, ratio, token, label) VALUES (62.43, 37, 97.12, 'green', 'cached');
INSERT INTO commits_records (score, active, ratio, token, label) VALUES (69.19, 90, 92.55, 'staging', 'local');
INSERT INTO commits_records (score, active, ratio, token, label) VALUES (25.31, 61, 55.88, 'edge', 'latest');
