-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (token, region, owner, score, active) VALUES ('stable', 'edge', 'fallback', 59.78, 2);
INSERT INTO commits_records (token, region, owner, score, active) VALUES ('green', 'stable', 'open', 37.06, 47);
INSERT INTO commits_records (token, region, owner, score, active) VALUES ('open', 'blue', 'latest', 76.66, 66);
