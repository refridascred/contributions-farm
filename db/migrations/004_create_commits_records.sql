-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (rank, level, active) VALUES (86, 89, 27);
INSERT INTO commits_records (rank, level, active) VALUES (91, 78, 6);
INSERT INTO commits_records (rank, level, active) VALUES (75, 42, 2);
