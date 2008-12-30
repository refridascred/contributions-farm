-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (level, score, label, weight, count) VALUES (62, 8.78, 'latest', 48.59, 89);
INSERT INTO commits_records (level, score, label, weight, count) VALUES (86, 47.48, 'open', 71.26, 26);
INSERT INTO commits_records (level, score, label, weight, count) VALUES (75, 56.18, 'fallback', 94.97, 76);
