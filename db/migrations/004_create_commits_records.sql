-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, ratio, rank) VALUES (19, 22.83, 49);
INSERT INTO commits_records (level, ratio, rank) VALUES (56, 3.81, 62);
INSERT INTO commits_records (level, ratio, rank) VALUES (13, 54.78, 84);
