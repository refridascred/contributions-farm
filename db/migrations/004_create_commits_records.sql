-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (weight, owner, score, level) VALUES (70.76, 'cached', 64.89, 72);
INSERT INTO commits_records (weight, owner, score, level) VALUES (42.98, 'edge', 15.64, 86);
