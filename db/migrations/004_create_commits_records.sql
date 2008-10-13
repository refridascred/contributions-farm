-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    weight REAL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, region, weight, level) VALUES (9.9, 'strict', 69.91, 91);
INSERT INTO commits_records (ratio, region, weight, level) VALUES (17.85, 'edge', 3.94, 41);
