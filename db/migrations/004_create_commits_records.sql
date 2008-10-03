-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, region, level) VALUES (11.56, 'cached', 35);
INSERT INTO commits_records (ratio, region, level) VALUES (20.15, 'blue', 43);
INSERT INTO commits_records (ratio, region, level) VALUES (83.56, 'blue', 31);
