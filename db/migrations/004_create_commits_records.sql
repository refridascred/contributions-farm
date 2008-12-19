-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, score, region, ratio) VALUES (52.67, 65.52, 'latest', 68.69);
INSERT INTO commits_records (weight, score, region, ratio) VALUES (62.61, 63.09, 'stable', 10.47);
