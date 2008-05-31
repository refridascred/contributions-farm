-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (count, label, active, weight, token) VALUES (45, 'open', 63, 57.48, 'blue');
INSERT INTO commits_records (count, label, active, weight, token) VALUES (47, 'legacy', 41, 80.2, 'stable');
