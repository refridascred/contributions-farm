-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (region, weight, level, ratio) VALUES ('edge', 15.78, 24, 0.74);
INSERT INTO commits_records (region, weight, level, ratio) VALUES ('legacy', 36.72, 81, 6.99);
