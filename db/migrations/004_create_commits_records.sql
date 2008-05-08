-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (level, ratio, score, label, active) VALUES (71, 59.93, 80.13, 'legacy', 65);
INSERT INTO commits_records (level, ratio, score, label, active) VALUES (7, 11.18, 82.9, 'blue', 41);
INSERT INTO commits_records (level, ratio, score, label, active) VALUES (18, 83.51, 12.44, 'standard', 41);
