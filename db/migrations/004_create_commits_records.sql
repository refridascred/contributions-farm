-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (ratio, level, score, state, count) VALUES (20.28, 83, 65.52, 'legacy', 97);
INSERT INTO commits_records (ratio, level, score, state, count) VALUES (94.34, 68, 79.84, 'primary', 42);
