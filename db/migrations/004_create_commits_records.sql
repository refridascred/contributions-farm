-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, score, region, weight, label) VALUES ('stable', 43.07, 'stable', 0.47, 'stable');
INSERT INTO commits_records (token, score, region, weight, label) VALUES ('legacy', 14.04, 'staging', 72.3, 'staging');
INSERT INTO commits_records (token, score, region, weight, label) VALUES ('staging', 57.75, 'blue', 51.85, 'strict');
