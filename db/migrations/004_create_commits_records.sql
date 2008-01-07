-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, state, region, active) VALUES (1.66, 'local', 'local', 7);
INSERT INTO commits_records (score, state, region, active) VALUES (81.65, 'strict', 'fallback', 44);
INSERT INTO commits_records (score, state, region, active) VALUES (42.42, 'eu-west', 'staging', 71);
