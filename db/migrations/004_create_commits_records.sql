-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (score, count, active, weight, label) VALUES (23.59, 80, 9, 45.42, 'green');
INSERT INTO commits_records (score, count, active, weight, label) VALUES (44.37, 97, 68, 38.74, 'latest');
