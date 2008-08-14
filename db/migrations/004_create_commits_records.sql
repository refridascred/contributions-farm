-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, region, score, rank) VALUES (85.63, 'strict', 83.23, 25);
INSERT INTO commits_records (weight, region, score, rank) VALUES (71.05, 'open', 17.35, 29);
INSERT INTO commits_records (weight, region, score, rank) VALUES (34.79, 'eu-west', 34.03, 61);
