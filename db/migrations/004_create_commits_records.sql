-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, weight, active, state, ratio) VALUES (55, 19.36, 65, 'edge', 44.24);
INSERT INTO commits_records (rank, weight, active, state, ratio) VALUES (75, 42.32, 1, 'green', 39.34);
