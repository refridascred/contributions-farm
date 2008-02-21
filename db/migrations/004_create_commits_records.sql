-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, active, ratio, count) VALUES (71.36, 91, 38.53, 24);
INSERT INTO commits_records (weight, active, ratio, count) VALUES (45.68, 17, 92.23, 1);
INSERT INTO commits_records (weight, active, ratio, count) VALUES (24.95, 92, 9.83, 78);
