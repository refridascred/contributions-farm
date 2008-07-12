-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, count, active, label, ratio) VALUES (60.07, 7, 57, 'legacy', 33.15);
INSERT INTO commits_records (weight, count, active, label, ratio) VALUES (73.62, 27, 0, 'cached', 54.97);
