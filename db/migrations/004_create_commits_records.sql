-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (weight, ratio, score, active) VALUES (20.82, 82.79, 80.85, 17);
INSERT INTO commits_records (weight, ratio, score, active) VALUES (19.8, 80.36, 10.88, 46);
