-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, ratio, weight) VALUES ('green', 80.34, 32.86);
INSERT INTO commits_records (region, ratio, weight) VALUES ('blue', 15.67, 63.12);
INSERT INTO commits_records (region, ratio, weight) VALUES ('cached', 76.74, 18.87);
