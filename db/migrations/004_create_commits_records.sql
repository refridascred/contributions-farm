-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (count, score) VALUES (95, 7.49);
INSERT INTO commits_records (count, score) VALUES (58, 57.92);
INSERT INTO commits_records (count, score) VALUES (35, 96.77);
