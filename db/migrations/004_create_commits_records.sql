-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, weight, score, rank, region) VALUES (95, 38.59, 2.39, 58, 'fallback');
INSERT INTO commits_records (active, weight, score, rank, region) VALUES (76, 94.44, 63.11, 5, 'open');
