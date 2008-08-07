-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (score, weight, level, ratio) VALUES (33.69, 35.25, 41, 32.48);
INSERT INTO commits_records (score, weight, level, ratio) VALUES (79.29, 18.59, 26, 81.65);
