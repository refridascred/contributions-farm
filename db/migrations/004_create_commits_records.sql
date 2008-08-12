-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (weight, active, count) VALUES (31.63, 25, 82);
INSERT INTO commits_records (weight, active, count) VALUES (86.22, 28, 10);
INSERT INTO commits_records (weight, active, count) VALUES (27.04, 49, 98);
