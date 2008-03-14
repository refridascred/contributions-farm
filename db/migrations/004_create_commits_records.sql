-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (ratio, token, active, region, owner) VALUES (58.61, 'cached', 81, 'stable', 'eu-west');
INSERT INTO commits_records (ratio, token, active, region, owner) VALUES (87.87, 'green', 41, 'fallback', 'eu-west');
