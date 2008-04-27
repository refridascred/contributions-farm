-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, level, region, token) VALUES (83.71, 56, 'legacy', 'local');
INSERT INTO commits_records (ratio, level, region, token) VALUES (58.4, 74, 'legacy', 'legacy');
INSERT INTO commits_records (ratio, level, region, token) VALUES (94.77, 80, 'legacy', 'primary');
