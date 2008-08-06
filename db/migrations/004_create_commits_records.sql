-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, region, level, label, count) VALUES (56.12, 'legacy', 27, 'legacy', 8);
INSERT INTO commits_records (weight, region, level, label, count) VALUES (95.76, 'strict', 62, 'open', 70);
INSERT INTO commits_records (weight, region, level, label, count) VALUES (89.33, 'blue', 32, 'eu-west', 81);
