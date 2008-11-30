-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    ratio REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, region, ratio, label, active) VALUES (68.81, 'green', 86.93, 'cached', 53);
INSERT INTO commits_records (weight, region, ratio, label, active) VALUES (82.72, 'staging', 89.81, 'open', 73);
INSERT INTO commits_records (weight, region, ratio, label, active) VALUES (21.86, 'eu-west', 12.97, 'green', 10);
