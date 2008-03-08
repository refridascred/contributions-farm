-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (count, region, token, level, rank) VALUES (38, 'fallback', 'cached', 23, 41);
INSERT INTO commits_records (count, region, token, level, rank) VALUES (38, 'primary', 'cached', 25, 2);
