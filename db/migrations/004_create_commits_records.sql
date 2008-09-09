-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (region, ratio) VALUES ('eu-west', 3.27);
INSERT INTO commits_records (region, ratio) VALUES ('staging', 24.8);
INSERT INTO commits_records (region, ratio) VALUES ('open', 46.05);
