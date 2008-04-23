-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (weight, token, state, level, score) VALUES (91.44, 'open', 'legacy', 79, 91.62);
INSERT INTO commits_records (weight, token, state, level, score) VALUES (85.2, 'latest', 'latest', 41, 76.5);
