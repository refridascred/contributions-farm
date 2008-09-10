-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (count, active, score) VALUES (4, 35, 23.22);
INSERT INTO commits_records (count, active, score) VALUES (41, 16, 18.82);
INSERT INTO commits_records (count, active, score) VALUES (3, 94, 98.99);
