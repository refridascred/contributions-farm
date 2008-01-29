-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (score, ratio, region, level) VALUES (55.49, 83.74, 'strict', 74);
INSERT INTO commits_records (score, ratio, region, level) VALUES (7.06, 50.71, 'standard', 27);
INSERT INTO commits_records (score, ratio, region, level) VALUES (35.02, 80.58, 'open', 93);
