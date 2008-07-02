-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, rank, active) VALUES (44.7, 35, 55);
INSERT INTO commits_records (score, rank, active) VALUES (66.37, 13, 83);
INSERT INTO commits_records (score, rank, active) VALUES (8.42, 45, 31);
