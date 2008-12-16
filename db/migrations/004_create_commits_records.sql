-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (state, weight, ratio, token) VALUES ('stable', 22.99, 77.24, 'edge');
INSERT INTO commits_records (state, weight, ratio, token) VALUES ('eu-west', 50.08, 81.04, 'blue');
INSERT INTO commits_records (state, weight, ratio, token) VALUES ('blue', 84.19, 23.97, 'strict');
