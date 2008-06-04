-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    label TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, token, label, ratio, weight) VALUES (83, 'primary', 'edge', 9.84, 79.23);
INSERT INTO commits_records (rank, token, label, ratio, weight) VALUES (14, 'local', 'fallback', 10.8, 91.09);
