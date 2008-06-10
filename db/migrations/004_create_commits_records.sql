-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, rank, active) VALUES ('local', 29, 73);
INSERT INTO commits_records (region, rank, active) VALUES ('blue', 93, 10);
INSERT INTO commits_records (region, rank, active) VALUES ('stable', 7, 52);
