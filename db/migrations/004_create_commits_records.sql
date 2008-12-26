-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, region, active) VALUES (37.43, 'fallback', 15);
INSERT INTO commits_records (score, region, active) VALUES (7.21, 'local', 6);
INSERT INTO commits_records (score, region, active) VALUES (55.36, 'stable', 24);
