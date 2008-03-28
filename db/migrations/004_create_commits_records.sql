-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, score, rank, label) VALUES (59, 44.69, 2, 'fallback');
INSERT INTO commits_records (active, score, rank, label) VALUES (14, 39.23, 32, 'stable');
INSERT INTO commits_records (active, score, rank, label) VALUES (16, 80.12, 53, 'latest');
