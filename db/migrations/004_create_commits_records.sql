-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (count, active, weight) VALUES (67, 72, 2.8);
INSERT INTO commits_records (count, active, weight) VALUES (47, 4, 91.68);
INSERT INTO commits_records (count, active, weight) VALUES (9, 74, 74.13);
