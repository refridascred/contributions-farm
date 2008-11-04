-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, region, rank, count, label) VALUES (44.64, 'edge', 54, 87, 'standard');
INSERT INTO layout_items (ratio, region, rank, count, label) VALUES (18.37, 'latest', 90, 65, 'eu-west');
