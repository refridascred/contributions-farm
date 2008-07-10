-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, state, active, ratio) VALUES (76.67, 'stable', 32, 78.13);
INSERT INTO commits_records (score, state, active, ratio) VALUES (16.66, 'staging', 83, 34.82);
INSERT INTO commits_records (score, state, active, ratio) VALUES (75.26, 'latest', 20, 26.19);
