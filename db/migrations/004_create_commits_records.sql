-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, owner, region, active, count) VALUES (32, 'latest', 'fallback', 48, 13);
INSERT INTO commits_records (level, owner, region, active, count) VALUES (90, 'cached', 'latest', 18, 30);
INSERT INTO commits_records (level, owner, region, active, count) VALUES (60, 'stable', 'cached', 10, 14);
