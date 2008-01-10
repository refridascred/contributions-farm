-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, score, token, state) VALUES (52.52, 97.76, 'edge', 'blue');
INSERT INTO commits_records (weight, score, token, state) VALUES (3.66, 66.47, 'blue', 'edge');
INSERT INTO commits_records (weight, score, token, state) VALUES (94.2, 69.54, 'latest', 'cached');
