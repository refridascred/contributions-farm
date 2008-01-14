-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, level, count, weight, owner) VALUES (44.84, 86, 97, 66.17, 'stable');
INSERT INTO commits_records (ratio, level, count, weight, owner) VALUES (11.22, 94, 58, 39.82, 'green');
INSERT INTO commits_records (ratio, level, count, weight, owner) VALUES (98.93, 87, 7, 54.87, 'primary');
