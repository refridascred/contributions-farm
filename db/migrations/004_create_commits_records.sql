-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, level, weight, count, label) VALUES (81.29, 41, 55.69, 46, 'latest');
INSERT INTO commits_records (ratio, level, weight, count, label) VALUES (27.9, 37, 28.27, 16, 'eu-west');
INSERT INTO commits_records (ratio, level, weight, count, label) VALUES (23.4, 24, 38.51, 91, 'legacy');
