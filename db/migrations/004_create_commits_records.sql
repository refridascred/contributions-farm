-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (weight, rank, region, active) VALUES (31.35, 14, 'fallback', 96);
INSERT INTO commits_records (weight, rank, region, active) VALUES (8.4, 56, 'blue', 75);
INSERT INTO commits_records (weight, rank, region, active) VALUES (65.38, 41, 'eu-west', 26);
