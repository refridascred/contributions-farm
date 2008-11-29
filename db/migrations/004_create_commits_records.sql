-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, level, count, score, weight) VALUES ('green', 46, 90, 13.42, 47.86);
INSERT INTO commits_records (label, level, count, score, weight) VALUES ('fallback', 12, 60, 67.6, 24.47);
INSERT INTO commits_records (label, level, count, score, weight) VALUES ('stable', 76, 32, 54.88, 37.35);
