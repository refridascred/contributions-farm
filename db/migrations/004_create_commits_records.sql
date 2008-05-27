-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (score, ratio, state, token, level) VALUES (66.06, 86.34, 'fallback', 'green', 56);
INSERT INTO commits_records (score, ratio, state, token, level) VALUES (39.77, 54.02, 'legacy', 'local', 78);
INSERT INTO commits_records (score, ratio, state, token, level) VALUES (0.57, 57.61, 'local', 'blue', 48);
