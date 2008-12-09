-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (region, score, state, level, active) VALUES ('edge', 14.51, 'staging', 37, 36);
INSERT INTO commits_records (region, score, state, level, active) VALUES ('local', 94.29, 'legacy', 70, 63);
