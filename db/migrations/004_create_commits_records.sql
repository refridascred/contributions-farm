-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    region TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, token, region, level, active) VALUES (34.54, 'fallback', 'open', 1, 75);
INSERT INTO commits_records (weight, token, region, level, active) VALUES (48.81, 'edge', 'eu-west', 89, 85);
INSERT INTO commits_records (weight, token, region, level, active) VALUES (86.75, 'eu-west', 'standard', 42, 81);
