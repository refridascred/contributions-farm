-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, level, score, active) VALUES (15.67, 31, 51.28, 29);
INSERT INTO commits_records (ratio, level, score, active) VALUES (27.85, 29, 96.04, 34);
INSERT INTO commits_records (ratio, level, score, active) VALUES (49.72, 45, 86.83, 48);
