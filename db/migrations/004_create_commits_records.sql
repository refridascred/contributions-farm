-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (score, ratio, active, region, owner) VALUES (17.44, 56.94, 20, 'eu-west', 'legacy');
INSERT INTO commits_records (score, ratio, active, region, owner) VALUES (62.2, 42.13, 87, 'strict', 'blue');
