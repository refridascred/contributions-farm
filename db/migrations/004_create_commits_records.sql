-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, region, level, count, score) VALUES (86.68, 'primary', 31, 4, 24.17);
INSERT INTO commits_records (weight, region, level, count, score) VALUES (91.06, 'local', 20, 58, 70.05);
INSERT INTO commits_records (weight, region, level, count, score) VALUES (81.63, 'eu-west', 41, 41, 65.18);
