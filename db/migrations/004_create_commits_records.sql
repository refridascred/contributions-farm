-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, ratio, weight, count, token) VALUES ('fallback', 64.95, 38.61, 84, 'local');
INSERT INTO commits_records (label, ratio, weight, count, token) VALUES ('stable', 65.44, 8.89, 99, 'green');
INSERT INTO commits_records (label, ratio, weight, count, token) VALUES ('staging', 25.69, 30.12, 32, 'strict');
