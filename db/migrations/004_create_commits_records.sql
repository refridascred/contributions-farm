-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (rank, level, active, owner) VALUES (68, 40, 52, 'standard');
INSERT INTO commits_records (rank, level, active, owner) VALUES (84, 27, 19, 'strict');
INSERT INTO commits_records (rank, level, active, owner) VALUES (75, 41, 53, 'legacy');
