-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, score, token, region, label) VALUES (59.79, 42.16, 'legacy', 'standard', 'fallback');
INSERT INTO commits_records (weight, score, token, region, label) VALUES (85.53, 62.59, 'legacy', 'local', 'strict');
INSERT INTO commits_records (weight, score, token, region, label) VALUES (30.55, 21.8, 'green', 'staging', 'stable');
