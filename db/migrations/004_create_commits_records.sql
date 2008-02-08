-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (level, ratio, weight, label, score) VALUES (17, 23.14, 23.42, 'cached', 17.88);
INSERT INTO commits_records (level, ratio, weight, label, score) VALUES (65, 49.55, 39.07, 'eu-west', 13.65);
