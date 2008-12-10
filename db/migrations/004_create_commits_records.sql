-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (token, region, weight, ratio) VALUES ('eu-west', 'edge', 58.87, 49.87);
INSERT INTO commits_records (token, region, weight, ratio) VALUES ('staging', 'stable', 13.74, 25.51);
