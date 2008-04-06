-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    region TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, rank, region, weight, ratio) VALUES (36, 96, 'strict', 49.6, 15.79);
INSERT INTO commits_records (level, rank, region, weight, ratio) VALUES (15, 70, 'local', 17.24, 79.55);
