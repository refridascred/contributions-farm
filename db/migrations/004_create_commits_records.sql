-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (count, active, score, rank) VALUES (41, 22, 14.55, 89);
INSERT INTO commits_records (count, active, score, rank) VALUES (1, 63, 76.91, 28);
INSERT INTO commits_records (count, active, score, rank) VALUES (45, 66, 58.52, 27);
