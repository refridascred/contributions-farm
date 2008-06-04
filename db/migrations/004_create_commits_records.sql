-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (rank, score, active, region, level) VALUES (54, 36.81, 14, 'fallback', 67);
INSERT INTO commits_records (rank, score, active, region, level) VALUES (26, 35.95, 11, 'fallback', 18);
