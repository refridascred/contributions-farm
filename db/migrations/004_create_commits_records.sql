-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (score, active, rank) VALUES (15.68, 42, 15);
INSERT INTO commits_records (score, active, rank) VALUES (83.14, 71, 87);
INSERT INTO commits_records (score, active, rank) VALUES (19.41, 75, 16);
