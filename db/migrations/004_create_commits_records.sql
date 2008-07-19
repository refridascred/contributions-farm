-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, level, token, weight, region) VALUES (11, 81, 'cached', 96.93, 'eu-west');
INSERT INTO commits_records (active, level, token, weight, region) VALUES (8, 85, 'blue', 15.11, 'green');
INSERT INTO commits_records (active, level, token, weight, region) VALUES (38, 50, 'fallback', 42.73, 'staging');
