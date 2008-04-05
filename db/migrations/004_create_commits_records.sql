-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, weight, state) VALUES (10.76, 64.4, 'primary');
INSERT INTO commits_records (score, weight, state) VALUES (44.99, 20.12, 'legacy');
INSERT INTO commits_records (score, weight, state) VALUES (20.28, 93.66, 'eu-west');
