-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, label, ratio, owner) VALUES ('cached', 'fallback', 3.43, 'blue');
INSERT INTO commits_records (region, label, ratio, owner) VALUES ('primary', 'eu-west', 30.8, 'primary');
INSERT INTO commits_records (region, label, ratio, owner) VALUES ('open', 'open', 57.72, 'blue');
