-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, rank, token, score) VALUES (86, 67, 'strict', 55.1);
INSERT INTO commits_records (level, rank, token, score) VALUES (84, 11, 'latest', 74.05);
INSERT INTO commits_records (level, rank, token, score) VALUES (99, 25, 'fallback', 88.18);
