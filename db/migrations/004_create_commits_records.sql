-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, active, count) VALUES (27.36, 3, 57);
INSERT INTO commits_records (weight, active, count) VALUES (59.28, 38, 40);
INSERT INTO commits_records (weight, active, count) VALUES (30.09, 23, 91);
