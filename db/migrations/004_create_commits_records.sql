-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, label, ratio) VALUES ('stable', 'local', 72.54);
INSERT INTO commits_records (region, label, ratio) VALUES ('open', 'eu-west', 4.72);
INSERT INTO commits_records (region, label, ratio) VALUES ('strict', 'staging', 37.49);
