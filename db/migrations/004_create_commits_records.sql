-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, active, level, rank) VALUES (70.66, 12, 41, 89);
INSERT INTO commits_records (score, active, level, rank) VALUES (95.31, 47, 85, 81);
INSERT INTO commits_records (score, active, level, rank) VALUES (25.76, 89, 72, 87);
