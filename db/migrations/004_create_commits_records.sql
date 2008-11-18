-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    weight REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (token, level, weight, rank, region) VALUES ('strict', 88, 50.95, 50, 'edge');
INSERT INTO commits_records (token, level, weight, rank, region) VALUES ('green', 4, 68.98, 93, 'cached');
INSERT INTO commits_records (token, level, weight, rank, region) VALUES ('eu-west', 84, 63.27, 87, 'edge');
