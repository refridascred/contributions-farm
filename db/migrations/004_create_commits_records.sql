-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, count, active, level) VALUES (27.45, 87, 62, 73);
INSERT INTO commits_records (score, count, active, level) VALUES (91.63, 77, 89, 50);
