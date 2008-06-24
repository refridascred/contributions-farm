-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, level, weight, ratio, label) VALUES (64.96, 96, 86.56, 5.9, 'strict');
INSERT INTO commits_records (score, level, weight, ratio, label) VALUES (37.14, 51, 93.97, 60.15, 'edge');
