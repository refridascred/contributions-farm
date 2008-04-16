-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, level, ratio, rank) VALUES ('strict', 46, 22.19, 98);
INSERT INTO commits_records (owner, level, ratio, rank) VALUES ('cached', 87, 28.53, 88);
