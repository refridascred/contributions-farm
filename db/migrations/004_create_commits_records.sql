-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (weight, level, region, active, ratio) VALUES (87.6, 19, 'fallback', 48, 90.59);
INSERT INTO commits_records (weight, level, region, active, ratio) VALUES (1.22, 7, 'local', 27, 94.86);
INSERT INTO commits_records (weight, level, region, active, ratio) VALUES (52.96, 89, 'fallback', 43, 69.23);
