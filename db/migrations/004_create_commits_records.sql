-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, label, weight, score) VALUES (58, 'strict', 14.58, 62.71);
INSERT INTO commits_records (count, label, weight, score) VALUES (43, 'local', 3.53, 16.63);
INSERT INTO commits_records (count, label, weight, score) VALUES (0, 'legacy', 38.09, 6.78);
