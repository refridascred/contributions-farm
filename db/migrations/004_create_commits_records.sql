-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, region, score, owner) VALUES (83, 'stable', 18.92, 'open');
INSERT INTO commits_records (level, region, score, owner) VALUES (55, 'green', 66.1, 'open');
