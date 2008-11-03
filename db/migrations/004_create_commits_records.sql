-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, ratio, score, label) VALUES (62, 98.44, 50.86, 'eu-west');
INSERT INTO commits_records (level, ratio, score, label) VALUES (86, 32.16, 97.41, 'stable');
