-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (ratio, score, active) VALUES (11.71, 72.55, 10);
INSERT INTO commits_records (ratio, score, active) VALUES (92.69, 67.64, 59);
INSERT INTO commits_records (ratio, score, active) VALUES (25.53, 17.22, 51);
