-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, label, region, score) VALUES (14, 'fallback', 'local', 91.32);
INSERT INTO commits_records (count, label, region, score) VALUES (33, 'open', 'cached', 16.12);
INSERT INTO commits_records (count, label, region, score) VALUES (58, 'open', 'local', 19.17);
