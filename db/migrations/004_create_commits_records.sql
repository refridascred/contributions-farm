-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, level) VALUES (22.05, 94);
INSERT INTO commits_records (ratio, level) VALUES (0.25, 85);
INSERT INTO commits_records (ratio, level) VALUES (50.55, 41);
