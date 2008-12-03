-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (count, token, weight, rank, label) VALUES (12, 'stable', 58.36, 22, 'stable');
INSERT INTO commits_records (count, token, weight, rank, label) VALUES (58, 'staging', 0.31, 8, 'latest');
INSERT INTO commits_records (count, token, weight, rank, label) VALUES (26, 'edge', 83.75, 18, 'edge');
