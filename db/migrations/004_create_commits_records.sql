-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, level, token, weight, owner) VALUES (7.22, 91, 'fallback', 8.75, 'blue');
INSERT INTO commits_records (ratio, level, token, weight, owner) VALUES (48.01, 14, 'blue', 92.57, 'open');
