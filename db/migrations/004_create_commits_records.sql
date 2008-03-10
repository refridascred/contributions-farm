-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, rank, score, count, label) VALUES ('primary', 49, 80.67, 34, 'legacy');
INSERT INTO commits_records (token, rank, score, count, label) VALUES ('staging', 77, 41.73, 14, 'standard');
INSERT INTO commits_records (token, rank, score, count, label) VALUES ('local', 77, 54.41, 53, 'latest');
