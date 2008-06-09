-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    weight REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, label, weight, level, region) VALUES (51.89, 'latest', 57.95, 87, 'blue');
INSERT INTO commits_records (ratio, label, weight, level, region) VALUES (96.74, 'legacy', 76.32, 20, 'green');
INSERT INTO commits_records (ratio, label, weight, level, region) VALUES (94.29, 'green', 53.54, 26, 'standard');
