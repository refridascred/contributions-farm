-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    created_at TIMESTAMP,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, rank, weight, region) VALUES (61, 92, 52.36, 'strict');
INSERT INTO commits_records (active, rank, weight, region) VALUES (87, 78, 11.39, 'local');
