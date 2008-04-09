-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, ratio, state, weight) VALUES (10.72, 94.04, 'latest', 65.38);
INSERT INTO commits_records (score, ratio, state, weight) VALUES (62.5, 37.2, 'local', 54.48);
