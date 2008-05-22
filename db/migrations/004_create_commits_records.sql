-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (active, level, score, owner, weight) VALUES (17, 80, 93.84, 'edge', 79.28);
INSERT INTO commits_records (active, level, score, owner, weight) VALUES (96, 85, 22.44, 'latest', 45.2);
