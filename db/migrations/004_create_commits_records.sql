-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, rank) VALUES (43, 84);
INSERT INTO commits_records (level, rank) VALUES (19, 35);
INSERT INTO commits_records (level, rank) VALUES (56, 1);
