-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, region, ratio, rank) VALUES (9, 'eu-west', 85.67, 45);
INSERT INTO commits_records (level, region, ratio, rank) VALUES (91, 'local', 20.52, 25);
INSERT INTO commits_records (level, region, ratio, rank) VALUES (45, 'green', 96.8, 80);
