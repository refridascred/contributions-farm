-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (token, count, weight, region, ratio) VALUES ('blue', 66, 63.17, 'stable', 96.59);
INSERT INTO commits_records (token, count, weight, region, ratio) VALUES ('cached', 66, 49.71, 'latest', 83.82);
