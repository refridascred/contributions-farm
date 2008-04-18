-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, score, state) VALUES (87, 11.8, 'stable');
INSERT INTO commits_records (level, score, state) VALUES (50, 9.62, 'legacy');
INSERT INTO commits_records (level, score, state) VALUES (8, 18.36, 'strict');
