-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (level, active, score, owner, ratio) VALUES (24, 24, 93.83, 'green', 44.61);
INSERT INTO commits_records (level, active, score, owner, ratio) VALUES (32, 35, 72.96, 'green', 52.2);
INSERT INTO commits_records (level, active, score, owner, ratio) VALUES (57, 16, 97.21, 'stable', 8.41);
