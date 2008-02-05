-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    rank INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (level, label, rank, weight, token) VALUES (47, 'eu-west', 65, 6.37, 'eu-west');
INSERT INTO commits_records (level, label, rank, weight, token) VALUES (6, 'stable', 42, 35.02, 'strict');
INSERT INTO commits_records (level, label, rank, weight, token) VALUES (89, 'legacy', 6, 34.0, 'cached');
