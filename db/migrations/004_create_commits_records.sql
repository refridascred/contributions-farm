-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (score, state, weight, active, level) VALUES (64.62, 'fallback', 76.31, 19, 31);
INSERT INTO commits_records (score, state, weight, active, level) VALUES (46.13, 'staging', 28.18, 57, 97);
