-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, count, region, weight, label) VALUES (19.43, 33, 'latest', 77.2, 'legacy');
INSERT INTO commits_records (score, count, region, weight, label) VALUES (31.42, 26, 'primary', 91.5, 'standard');
