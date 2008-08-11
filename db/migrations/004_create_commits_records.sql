-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (active, weight, count) VALUES (82, 31.92, 52);
INSERT INTO commits_records (active, weight, count) VALUES (57, 97.07, 54);
INSERT INTO commits_records (active, weight, count) VALUES (7, 31.65, 86);
