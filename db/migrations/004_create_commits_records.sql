-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (active, rank, score) VALUES (12, 28, 38.85);
INSERT INTO commits_records (active, rank, score) VALUES (26, 4, 29.77);
INSERT INTO commits_records (active, rank, score) VALUES (23, 22, 33.11);
