-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    label TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (token, weight, label, level, count) VALUES ('green', 97.87, 'edge', 99, 99);
INSERT INTO commits_records (token, weight, label, level, count) VALUES ('open', 98.62, 'eu-west', 90, 83);
INSERT INTO commits_records (token, weight, label, level, count) VALUES ('strict', 93.83, 'cached', 43, 41);
