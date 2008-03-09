-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, weight, ratio, state) VALUES (47.43, 37.84, 78.51, 'legacy');
INSERT INTO commits_records (score, weight, ratio, state) VALUES (52.9, 56.63, 89.76, 'eu-west');
