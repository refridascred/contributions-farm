-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (count, active, level, rank) VALUES (43, 55, 99, 67);
INSERT INTO commits_records (count, active, level, rank) VALUES (90, 6, 15, 10);
INSERT INTO commits_records (count, active, level, rank) VALUES (83, 77, 75, 39);
