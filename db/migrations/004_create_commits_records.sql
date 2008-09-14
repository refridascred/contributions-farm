-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, token, ratio, level) VALUES ('primary', 'fallback', 14.72, 91);
INSERT INTO commits_records (region, token, ratio, level) VALUES ('blue', 'open', 62.67, 57);
