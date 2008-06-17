-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, score, token, region, count) VALUES (83, 92.81, 'staging', 'green', 56);
INSERT INTO commits_records (level, score, token, region, count) VALUES (62, 84.52, 'green', 'green', 29);
