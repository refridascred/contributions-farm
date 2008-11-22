-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (owner, region, rank) VALUES ('staging', 'blue', 71);
INSERT INTO commits_records (owner, region, rank) VALUES ('strict', 'strict', 48);
INSERT INTO commits_records (owner, region, rank) VALUES ('fallback', 'eu-west', 44);
