-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (score, active, region, weight, rank) VALUES (48.28, 75, 'eu-west', 23.96, 26);
INSERT INTO commits_records (score, active, region, weight, rank) VALUES (9.21, 40, 'edge', 62.08, 96);
