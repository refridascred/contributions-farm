-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (count, score, active) VALUES (2, 88.74, 97);
INSERT INTO commits_records (count, score, active) VALUES (78, 98.41, 55);
INSERT INTO commits_records (count, score, active) VALUES (6, 20.93, 99);
