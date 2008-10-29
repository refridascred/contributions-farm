-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, label, ratio) VALUES (21.44, 'cached', 52.62);
INSERT INTO commits_records (weight, label, ratio) VALUES (2.61, 'stable', 6.01);
INSERT INTO commits_records (weight, label, ratio) VALUES (58.87, 'cached', 88.42);
