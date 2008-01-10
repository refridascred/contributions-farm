-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    weight REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (ratio, region, weight, label, level) VALUES (72.22, 'stable', 12.56, 'strict', 24);
INSERT INTO commits_records (ratio, region, weight, label, level) VALUES (12.03, 'latest', 31.83, 'fallback', 97);
