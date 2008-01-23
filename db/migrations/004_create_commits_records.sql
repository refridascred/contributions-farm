-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, owner, token, score, ratio) VALUES (82, 'edge', 'strict', 7.08, 59.0);
INSERT INTO commits_records (level, owner, token, score, ratio) VALUES (85, 'edge', 'local', 48.82, 75.02);
