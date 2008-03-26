-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (active, level, count, rank) VALUES (65, 7, 49, 64);
INSERT INTO commits_records (active, level, count, rank) VALUES (54, 1, 79, 4);
INSERT INTO commits_records (active, level, count, rank) VALUES (97, 13, 78, 79);
