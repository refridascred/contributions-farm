-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, score, ratio, state, level) VALUES ('edge', 14.83, 5.02, 'fallback', 24);
INSERT INTO commits_records (owner, score, ratio, state, level) VALUES ('open', 85.88, 85.07, 'edge', 92);
