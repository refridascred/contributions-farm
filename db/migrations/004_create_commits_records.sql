-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, state, weight) VALUES (53.02, 'legacy', 85.81);
INSERT INTO commits_records (score, state, weight) VALUES (93.3, 'strict', 58.8);
INSERT INTO commits_records (score, state, weight) VALUES (74.92, 'latest', 71.59);
