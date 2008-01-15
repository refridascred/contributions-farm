-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, score, active) VALUES (86, 49.67, 81);
INSERT INTO commits_records (level, score, active) VALUES (12, 80.72, 40);
INSERT INTO commits_records (level, score, active) VALUES (10, 38.31, 38);
