-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, count, active, level) VALUES (43.34, 22, 32, 78);
INSERT INTO commits_records (score, count, active, level) VALUES (11.2, 38, 78, 36);
INSERT INTO commits_records (score, count, active, level) VALUES (91.2, 20, 50, 18);
