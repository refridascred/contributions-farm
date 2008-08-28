-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, rank, active, token, region) VALUES (24.65, 46, 7, 'green', 'stable');
INSERT INTO commits_records (weight, rank, active, token, region) VALUES (9.25, 60, 95, 'fallback', 'edge');
INSERT INTO commits_records (weight, rank, active, token, region) VALUES (74.59, 96, 52, 'eu-west', 'blue');
