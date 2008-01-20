-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, token, level, count, region) VALUES (11.38, 'fallback', 13, 88, 'staging');
INSERT INTO commits_records (weight, token, level, count, region) VALUES (23.9, 'fallback', 98, 27, 'standard');
