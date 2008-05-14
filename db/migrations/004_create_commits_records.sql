-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, rank) VALUES ('legacy', 31);
INSERT INTO commits_records (region, rank) VALUES ('cached', 78);
INSERT INTO commits_records (region, rank) VALUES ('standard', 11);
