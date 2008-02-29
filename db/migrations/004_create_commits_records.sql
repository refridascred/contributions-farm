-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, level, label) VALUES ('eu-west', 15, 'fallback');
INSERT INTO commits_records (region, level, label) VALUES ('primary', 6, 'blue');
