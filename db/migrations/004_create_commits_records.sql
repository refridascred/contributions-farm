-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, level, active, region, score) VALUES (20.78, 12, 25, 'fallback', 25.1);
INSERT INTO commits_records (ratio, level, active, region, score) VALUES (52.86, 72, 42, 'local', 25.26);
INSERT INTO commits_records (ratio, level, active, region, score) VALUES (69.72, 27, 82, 'latest', 60.11);
