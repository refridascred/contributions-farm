-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, count, weight, ratio) VALUES (68, 56, 96.43, 37.72);
INSERT INTO commits_records (active, count, weight, ratio) VALUES (94, 65, 19.09, 20.05);
INSERT INTO commits_records (active, count, weight, ratio) VALUES (19, 72, 68.3, 27.11);
