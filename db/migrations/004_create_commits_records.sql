-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (active, weight, ratio, label, token) VALUES (85, 40.71, 3.96, 'open', 'standard');
INSERT INTO commits_records (active, weight, ratio, label, token) VALUES (67, 61.2, 59.66, 'edge', 'blue');
INSERT INTO commits_records (active, weight, ratio, label, token) VALUES (30, 97.76, 58.7, 'edge', 'standard');
