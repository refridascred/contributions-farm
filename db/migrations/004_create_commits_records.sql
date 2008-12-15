-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, state, weight, region, score) VALUES (12, 'green', 5.56, 'cached', 81.02);
INSERT INTO commits_records (level, state, weight, region, score) VALUES (3, 'stable', 31.7, 'legacy', 89.53);
