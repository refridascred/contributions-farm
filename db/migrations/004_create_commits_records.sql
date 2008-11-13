-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, rank, token, ratio) VALUES ('local', 92, 'eu-west', 54.42);
INSERT INTO commits_records (region, rank, token, ratio) VALUES ('green', 75, 'strict', 55.05);
