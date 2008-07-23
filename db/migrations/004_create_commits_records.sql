-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (ratio, rank, token, score) VALUES (12.05, 20, 'primary', 68.6);
INSERT INTO commits_records (ratio, rank, token, score) VALUES (18.54, 49, 'local', 88.77);
