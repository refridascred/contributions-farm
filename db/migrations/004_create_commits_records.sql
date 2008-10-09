-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, score, ratio, token, owner) VALUES ('green', 79.16, 83.65, 'green', 'legacy');
INSERT INTO commits_records (state, score, ratio, token, owner) VALUES ('stable', 56.9, 2.54, 'blue', 'stable');
