-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, weight, level) VALUES (48.76, 28.24, 94);
INSERT INTO commits_records (ratio, weight, level) VALUES (10.19, 88.22, 23);
INSERT INTO commits_records (ratio, weight, level) VALUES (89.38, 6.31, 31);
