-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, rank, active, level) VALUES ('stable', 15, 38, 73);
INSERT INTO commits_records (owner, rank, active, level) VALUES ('cached', 45, 30, 87);
INSERT INTO commits_records (owner, rank, active, level) VALUES ('cached', 21, 62, 96);
