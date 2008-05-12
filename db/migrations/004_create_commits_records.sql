-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, token, score, region) VALUES (34.4, 'standard', 32.3, 'staging');
INSERT INTO commits_records (weight, token, score, region) VALUES (73.9, 'fallback', 71.38, 'standard');
