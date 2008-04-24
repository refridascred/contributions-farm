-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, weight, token, label) VALUES (86, 39.76, 'strict', 'stable');
INSERT INTO commits_records (active, weight, token, label) VALUES (68, 84.81, 'stable', 'cached');
