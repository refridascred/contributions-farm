-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, region, level) VALUES (77.32, 'strict', 2);
INSERT INTO commits_records (weight, region, level) VALUES (33.14, 'strict', 17);
INSERT INTO commits_records (weight, region, level) VALUES (80.62, 'edge', 56);
