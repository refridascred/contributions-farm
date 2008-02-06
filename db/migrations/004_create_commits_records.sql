-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, level, weight, rank) VALUES (81.56, 37, 57.49, 63);
INSERT INTO commits_records (ratio, level, weight, rank) VALUES (42.52, 90, 50.95, 31);
INSERT INTO commits_records (ratio, level, weight, rank) VALUES (19.22, 6, 78.66, 68);
