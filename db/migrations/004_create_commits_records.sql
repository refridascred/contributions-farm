-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (label, level, ratio, score, owner) VALUES ('edge', 32, 55.24, 89.45, 'primary');
INSERT INTO commits_records (label, level, ratio, score, owner) VALUES ('fallback', 40, 0.82, 29.42, 'strict');
