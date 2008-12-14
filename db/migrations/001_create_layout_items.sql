-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    token TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, level, token, rank, region) VALUES (58.18, 62, 'staging', 98, 'latest');
INSERT INTO layout_items (ratio, level, token, rank, region) VALUES (34.94, 75, 'eu-west', 72, 'fallback');
INSERT INTO layout_items (ratio, level, token, rank, region) VALUES (30.32, 5, 'open', 15, 'latest');
