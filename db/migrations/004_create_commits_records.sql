-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, level) VALUES (42.37, 82);
INSERT INTO commits_records (ratio, level) VALUES (1.45, 6);
INSERT INTO commits_records (ratio, level) VALUES (25.31, 35);
