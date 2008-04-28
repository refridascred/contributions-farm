-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, weight, region, active) VALUES (50, 22.25, 'fallback', 58);
INSERT INTO commits_records (level, weight, region, active) VALUES (41, 68.19, 'standard', 1);
