-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (score, level, count) VALUES (36.72, 76, 3);
INSERT INTO commits_records (score, level, count) VALUES (1.11, 42, 96);
INSERT INTO commits_records (score, level, count) VALUES (92.35, 50, 85);
