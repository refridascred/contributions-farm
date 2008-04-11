-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, active, ratio, rank) VALUES ('legacy', 20, 53.0, 45);
INSERT INTO commits_records (owner, active, ratio, rank) VALUES ('legacy', 7, 50.14, 76);
