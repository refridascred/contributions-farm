-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (region, ratio, level, weight) VALUES ('open', 62.06, 72, 95.33);
INSERT INTO commits_records (region, ratio, level, weight) VALUES ('cached', 26.23, 97, 18.18);
INSERT INTO commits_records (region, ratio, level, weight) VALUES ('primary', 60.26, 17, 59.13);
