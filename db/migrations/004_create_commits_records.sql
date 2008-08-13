-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, score, label) VALUES (8, 75.5, 'latest');
INSERT INTO commits_records (rank, score, label) VALUES (52, 31.36, 'legacy');
INSERT INTO commits_records (rank, score, label) VALUES (58, 16.58, 'green');
