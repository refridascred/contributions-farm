-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (count, ratio, active, weight) VALUES (83, 82.41, 63, 3.81);
INSERT INTO commits_records (count, ratio, active, weight) VALUES (98, 50.38, 32, 81.3);
INSERT INTO commits_records (count, ratio, active, weight) VALUES (72, 61.71, 97, 69.43);
