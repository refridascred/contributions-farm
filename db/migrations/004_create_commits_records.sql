-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (level, region, weight) VALUES (85, 'cached', 37.93);
INSERT INTO commits_records (level, region, weight) VALUES (34, 'staging', 20.52);
