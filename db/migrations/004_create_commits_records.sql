-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, score, count, level, token) VALUES ('standard', 8.11, 17, 54, 'blue');
INSERT INTO commits_records (state, score, count, level, token) VALUES ('fallback', 95.45, 79, 88, 'fallback');
INSERT INTO commits_records (state, score, count, level, token) VALUES ('legacy', 75.12, 47, 95, 'blue');
