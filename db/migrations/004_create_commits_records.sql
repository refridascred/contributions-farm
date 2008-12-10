-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, score, owner) VALUES (4, 3.45, 'legacy');
INSERT INTO commits_records (level, score, owner) VALUES (94, 3.5, 'cached');
INSERT INTO commits_records (level, score, owner) VALUES (94, 48.48, 'edge');
