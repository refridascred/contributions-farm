-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (rank, score, label, ratio) VALUES (60, 33.47, 'cached', 9.47);
INSERT INTO commits_records (rank, score, label, ratio) VALUES (35, 35.14, 'standard', 57.17);
