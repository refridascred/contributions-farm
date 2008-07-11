-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, ratio, region, rank) VALUES (53.0, 45.23, 'latest', 85);
INSERT INTO layout_items (weight, ratio, region, rank) VALUES (9.03, 63.92, 'strict', 52);
INSERT INTO layout_items (weight, ratio, region, rank) VALUES (44.91, 77.84, 'green', 58);
