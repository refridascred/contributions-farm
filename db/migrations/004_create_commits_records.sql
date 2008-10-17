-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (count, ratio, token, level) VALUES (86, 61.8, 'local', 66);
INSERT INTO commits_records (count, ratio, token, level) VALUES (48, 6.71, 'local', 53);
