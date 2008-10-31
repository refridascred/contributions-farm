-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, active, level) VALUES (55, 25, 71);
INSERT INTO commits_records (rank, active, level) VALUES (39, 62, 85);
INSERT INTO commits_records (rank, active, level) VALUES (64, 40, 11);
