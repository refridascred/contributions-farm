-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, score, active) VALUES (4, 73.11, 59);
INSERT INTO commits_records (level, score, active) VALUES (50, 22.87, 30);
INSERT INTO commits_records (level, score, active) VALUES (96, 60.63, 67);
