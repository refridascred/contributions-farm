-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, weight) VALUES ('standard', 31.62);
INSERT INTO commits_records (region, weight) VALUES ('cached', 55.13);
INSERT INTO commits_records (region, weight) VALUES ('open', 33.42);
