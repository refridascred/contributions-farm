-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, count, level) VALUES (24, 64, 60);
INSERT INTO commits_records (rank, count, level) VALUES (83, 40, 89);
INSERT INTO commits_records (rank, count, level) VALUES (61, 17, 64);
