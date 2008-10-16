-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (level, count, weight, token) VALUES (40, 58, 39.32, 'strict');
INSERT INTO commits_records (level, count, weight, token) VALUES (98, 62, 90.36, 'standard');
INSERT INTO commits_records (level, count, weight, token) VALUES (37, 1, 53.4, 'standard');
