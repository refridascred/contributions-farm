-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, count, weight, ratio) VALUES ('cached', 0, 30.58, 43.68);
INSERT INTO commits_records (label, count, weight, ratio) VALUES ('open', 45, 92.01, 51.4);
