-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, label, weight, score, level) VALUES (29.84, 'staging', 7.81, 23.3, 7);
INSERT INTO commits_records (ratio, label, weight, score, level) VALUES (79.65, 'legacy', 23.36, 35.31, 58);
