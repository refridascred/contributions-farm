-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (score, count) VALUES (34.78, 72);
INSERT INTO commits_records (score, count) VALUES (10.8, 95);
INSERT INTO commits_records (score, count) VALUES (78.98, 33);
