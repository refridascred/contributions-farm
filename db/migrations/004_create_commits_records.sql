-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (level, weight, score, state, count) VALUES (65, 76.64, 54.67, 'stable', 30);
INSERT INTO commits_records (level, weight, score, state, count) VALUES (80, 69.56, 31.99, 'legacy', 89);
