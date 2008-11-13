-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (ratio, label, score, rank) VALUES (76.94, 'fallback', 30.93, 78);
INSERT INTO commits_records (ratio, label, score, rank) VALUES (22.76, 'cached', 71.8, 72);
