-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    level INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, ratio, level, weight, label) VALUES (38, 44.64, 78, 26.76, 'legacy');
INSERT INTO commits_records (active, ratio, level, weight, label) VALUES (61, 9.28, 2, 95.65, 'latest');
INSERT INTO commits_records (active, ratio, level, weight, label) VALUES (45, 35.89, 65, 79.34, 'standard');
