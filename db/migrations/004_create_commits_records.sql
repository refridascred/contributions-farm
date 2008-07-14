-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (score, weight, region) VALUES (49.1, 80.6, 'blue');
INSERT INTO commits_records (score, weight, region) VALUES (43.26, 5.9, 'fallback');
INSERT INTO commits_records (score, weight, region) VALUES (64.56, 81.32, 'standard');
