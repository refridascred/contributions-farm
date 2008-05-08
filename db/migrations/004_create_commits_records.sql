-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, rank, level) VALUES ('local', 25, 15);
INSERT INTO commits_records (region, rank, level) VALUES ('stable', 36, 93);
INSERT INTO commits_records (region, rank, level) VALUES ('strict', 37, 83);
