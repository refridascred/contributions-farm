-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, level, region) VALUES (21.36, 80, 'fallback');
INSERT INTO commits_records (ratio, level, region) VALUES (77.15, 2, 'cached');
