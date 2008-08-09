-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, ratio, active, level) VALUES (2, 18.18, 29, 82);
INSERT INTO commits_records (rank, ratio, active, level) VALUES (29, 54.72, 27, 9);
