-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, active, ratio) VALUES ('legacy', 42, 12.32);
INSERT INTO commits_records (region, active, ratio) VALUES ('strict', 84, 51.23);
INSERT INTO commits_records (region, active, ratio) VALUES ('latest', 20, 26.56);
