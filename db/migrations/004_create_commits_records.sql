-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (region, count, score, label, ratio) VALUES ('blue', 93, 57.36, 'staging', 49.72);
INSERT INTO commits_records (region, count, score, label, ratio) VALUES ('open', 91, 75.52, 'edge', 31.61);
INSERT INTO commits_records (region, count, score, label, ratio) VALUES ('open', 42, 85.18, 'primary', 84.51);
