-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (token, level, active, region, label) VALUES ('edge', 96, 19, 'fallback', 'legacy');
INSERT INTO commits_records (token, level, active, region, label) VALUES ('standard', 89, 1, 'eu-west', 'eu-west');
