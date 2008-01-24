-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (score, label, region, token, level) VALUES (48.24, 'blue', 'staging', 'open', 66);
INSERT INTO commits_records (score, label, region, token, level) VALUES (14.96, 'open', 'strict', 'stable', 85);
INSERT INTO commits_records (score, label, region, token, level) VALUES (63.16, 'latest', 'fallback', 'open', 35);
