-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, weight, score, state) VALUES ('legacy', 37.36, 57.12, 'latest');
INSERT INTO commits_records (token, weight, score, state) VALUES ('blue', 36.37, 39.5, 'fallback');
