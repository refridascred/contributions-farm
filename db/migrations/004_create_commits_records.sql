-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, region, label, weight) VALUES (7.38, 'stable', 'eu-west', 92.54);
INSERT INTO commits_records (ratio, region, label, weight) VALUES (16.17, 'standard', 'local', 53.7);
INSERT INTO commits_records (ratio, region, label, weight) VALUES (95.7, 'legacy', 'open', 0.7);
