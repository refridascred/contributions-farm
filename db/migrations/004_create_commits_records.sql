-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, active) VALUES (62.82, 54);
INSERT INTO commits_records (score, active) VALUES (36.13, 5);
INSERT INTO commits_records (score, active) VALUES (31.09, 4);
