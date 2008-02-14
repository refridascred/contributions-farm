-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (active, label, weight, count, rank) VALUES (7, 'local', 95.05, 34, 78);
INSERT INTO commits_records (active, label, weight, count, rank) VALUES (96, 'strict', 59.61, 33, 41);
