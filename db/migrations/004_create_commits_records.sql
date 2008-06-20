-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, owner, region, rank) VALUES (73.74, 'fallback', 'eu-west', 22);
INSERT INTO commits_records (weight, owner, region, rank) VALUES (84.67, 'edge', 'primary', 59);
INSERT INTO commits_records (weight, owner, region, rank) VALUES (16.12, 'fallback', 'blue', 7);
