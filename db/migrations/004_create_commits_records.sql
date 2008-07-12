-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, weight, region) VALUES (71, 14.09, 'cached');
INSERT INTO commits_records (level, weight, region) VALUES (10, 68.99, 'primary');
INSERT INTO commits_records (level, weight, region) VALUES (92, 46.88, 'legacy');
