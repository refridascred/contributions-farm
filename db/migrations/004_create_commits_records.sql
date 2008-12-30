-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, active, score) VALUES (80, 29, 10.62);
INSERT INTO commits_records (level, active, score) VALUES (39, 12, 95.54);
INSERT INTO commits_records (level, active, score) VALUES (37, 98, 36.16);
