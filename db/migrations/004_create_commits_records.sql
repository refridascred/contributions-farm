-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (count, active, weight) VALUES (25, 27, 29.76);
INSERT INTO commits_records (count, active, weight) VALUES (7, 7, 21.54);
INSERT INTO commits_records (count, active, weight) VALUES (26, 47, 35.53);
