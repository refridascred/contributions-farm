-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (score, level, active, region) VALUES (55.42, 23, 8, 'local');
INSERT INTO commits_records (score, level, active, region) VALUES (98.47, 50, 42, 'eu-west');
INSERT INTO commits_records (score, level, active, region) VALUES (50.79, 61, 89, 'legacy');
