-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (count, score) VALUES (5, 5.05);
INSERT INTO commits_records (count, score) VALUES (85, 60.5);
INSERT INTO commits_records (count, score) VALUES (64, 87.48);
