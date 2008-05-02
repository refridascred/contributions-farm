-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, active) VALUES (34.42, 67);
INSERT INTO commits_records (score, active) VALUES (28.98, 20);
INSERT INTO commits_records (score, active) VALUES (88.79, 83);
