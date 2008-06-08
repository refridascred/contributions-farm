-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (active, region, count, level, weight) VALUES (60, 'staging', 15, 80, 51.27);
INSERT INTO commits_records (active, region, count, level, weight) VALUES (63, 'stable', 36, 81, 17.24);
INSERT INTO commits_records (active, region, count, level, weight) VALUES (3, 'eu-west', 60, 11, 79.43);
