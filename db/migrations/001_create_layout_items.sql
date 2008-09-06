-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, rank, region, ratio) VALUES (32.43, 25, 'stable', 24.24);
INSERT INTO layout_items (weight, rank, region, ratio) VALUES (67.92, 46, 'cached', 74.27);
INSERT INTO layout_items (weight, rank, region, ratio) VALUES (38.89, 95, 'eu-west', 58.66);
