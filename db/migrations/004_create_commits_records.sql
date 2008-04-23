-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (count, state, weight, label) VALUES (24, 'legacy', 70.19, 'open');
INSERT INTO commits_records (count, state, weight, label) VALUES (60, 'edge', 77.68, 'local');
INSERT INTO commits_records (count, state, weight, label) VALUES (7, 'latest', 76.58, 'primary');
