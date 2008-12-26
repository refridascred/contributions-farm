-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (label, level, score, count) VALUES ('blue', 78, 7.94, 15);
INSERT INTO commits_records (label, level, score, count) VALUES ('primary', 82, 1.72, 13);
INSERT INTO commits_records (label, level, score, count) VALUES ('fallback', 64, 41.72, 81);
