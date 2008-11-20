-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (owner, level, count, rank) VALUES ('legacy', 69, 76, 68);
INSERT INTO commits_records (owner, level, count, rank) VALUES ('standard', 44, 78, 84);
INSERT INTO commits_records (owner, level, count, rank) VALUES ('open', 51, 85, 31);
