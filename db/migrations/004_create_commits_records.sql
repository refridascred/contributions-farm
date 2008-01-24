-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (count, token, region, active, level) VALUES (18, 'legacy', 'strict', 9, 95);
INSERT INTO commits_records (count, token, region, active, level) VALUES (35, 'strict', 'stable', 59, 20);
INSERT INTO commits_records (count, token, region, active, level) VALUES (67, 'stable', 'open', 43, 60);
