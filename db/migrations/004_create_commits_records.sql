-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, owner, token, level, weight) VALUES (45.01, 'legacy', 'strict', 45, 26.34);
INSERT INTO commits_records (score, owner, token, level, weight) VALUES (96.71, 'latest', 'edge', 37, 40.66);
