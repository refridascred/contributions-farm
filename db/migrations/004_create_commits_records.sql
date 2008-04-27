-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (score, owner, token, count, level) VALUES (71.71, 'eu-west', 'eu-west', 6, 7);
INSERT INTO commits_records (score, owner, token, count, level) VALUES (80.24, 'strict', 'fallback', 41, 66);
