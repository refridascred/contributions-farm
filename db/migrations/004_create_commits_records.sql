-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (count, level, ratio, token) VALUES (44, 78, 17.75, 'primary');
INSERT INTO commits_records (count, level, ratio, token) VALUES (82, 60, 85.56, 'latest');
