-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, weight, count, ratio) VALUES ('primary', 84.67, 4, 85.76);
INSERT INTO commits_records (label, weight, count, ratio) VALUES ('standard', 74.02, 93, 93.58);
INSERT INTO commits_records (label, weight, count, ratio) VALUES ('cached', 6.0, 13, 40.55);
