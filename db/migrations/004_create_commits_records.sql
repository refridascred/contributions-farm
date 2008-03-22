-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, state, region, token) VALUES (86.92, 'primary', 'cached', 'strict');
INSERT INTO commits_records (weight, state, region, token) VALUES (26.07, 'blue', 'strict', 'blue');
INSERT INTO commits_records (weight, state, region, token) VALUES (89.51, 'stable', 'staging', 'cached');
