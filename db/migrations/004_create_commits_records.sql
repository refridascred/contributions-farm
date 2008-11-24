-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, ratio, region) VALUES (71, 46.77, 'local');
INSERT INTO commits_records (level, ratio, region) VALUES (53, 23.98, 'strict');
INSERT INTO commits_records (level, ratio, region) VALUES (23, 97.5, 'green');
