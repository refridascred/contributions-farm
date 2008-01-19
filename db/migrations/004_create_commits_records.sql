-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (region, owner, score, active) VALUES ('staging', 'open', 16.77, 42);
INSERT INTO commits_records (region, owner, score, active) VALUES ('fallback', 'latest', 98.87, 7);
