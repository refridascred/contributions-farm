-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, level, region, label, active) VALUES (94.16, 58, 'legacy', 'open', 55);
INSERT INTO commits_records (ratio, level, region, label, active) VALUES (18.39, 92, 'staging', 'blue', 55);
INSERT INTO commits_records (ratio, level, region, label, active) VALUES (22.85, 66, 'cached', 'strict', 45);
