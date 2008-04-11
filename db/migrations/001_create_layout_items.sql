-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (label, token, region, ratio, rank) VALUES ('stable', 'open', 'blue', 61.23, 68);
INSERT INTO layout_items (label, token, region, ratio, rank) VALUES ('local', 'cached', 'latest', 58.78, 75);
INSERT INTO layout_items (label, token, region, ratio, rank) VALUES ('open', 'eu-west', 'staging', 44.55, 86);
