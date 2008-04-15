-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (weight, score, count, level) VALUES (68.49, 97.44, 90, 30);
INSERT INTO commits_records (weight, score, count, level) VALUES (93.74, 44.91, 69, 93);
INSERT INTO commits_records (weight, score, count, level) VALUES (79.02, 6.93, 42, 92);
