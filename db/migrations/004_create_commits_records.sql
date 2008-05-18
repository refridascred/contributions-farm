-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (region, token, score, active) VALUES ('local', 'stable', 34.72, 27);
INSERT INTO commits_records (region, token, score, active) VALUES ('strict', 'fallback', 79.92, 99);
