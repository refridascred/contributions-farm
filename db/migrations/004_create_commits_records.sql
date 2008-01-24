-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, level, token, weight) VALUES (20.35, 63, 'blue', 52.09);
INSERT INTO commits_records (ratio, level, token, weight) VALUES (71.64, 37, 'eu-west', 52.39);
