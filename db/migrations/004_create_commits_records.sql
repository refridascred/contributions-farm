-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, rank, ratio, level) VALUES ('local', 52, 84.59, 17);
INSERT INTO commits_records (region, rank, ratio, level) VALUES ('staging', 48, 26.45, 79);
INSERT INTO commits_records (region, rank, ratio, level) VALUES ('blue', 98, 56.0, 84);
