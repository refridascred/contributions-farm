-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (ratio, active, score, weight) VALUES (98.63, 71, 58.09, 59.72);
INSERT INTO commits_records (ratio, active, score, weight) VALUES (32.12, 13, 19.38, 46.1);
