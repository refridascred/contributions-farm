-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, level, count, token, label) VALUES (35.0, 68, 98, 'staging', 'stable');
INSERT INTO commits_records (weight, level, count, token, label) VALUES (65.06, 30, 14, 'stable', 'green');
