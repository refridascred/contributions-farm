-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, score, level, ratio, token) VALUES ('fallback', 42.87, 31, 36.68, 'cached');
INSERT INTO commits_records (state, score, level, ratio, token) VALUES ('blue', 54.62, 60, 77.88, 'edge');
