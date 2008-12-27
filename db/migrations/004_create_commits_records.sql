-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, count, region, weight) VALUES (62, 34, 'blue', 45.38);
INSERT INTO commits_records (active, count, region, weight) VALUES (34, 1, 'stable', 53.37);
