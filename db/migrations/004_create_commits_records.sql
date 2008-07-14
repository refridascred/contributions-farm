-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, rank, active) VALUES (49, 28, 32);
INSERT INTO commits_records (level, rank, active) VALUES (16, 92, 43);
INSERT INTO commits_records (level, rank, active) VALUES (97, 33, 32);
