-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, ratio, count) VALUES (20.97, 1.43, 20);
INSERT INTO layout_items (weight, ratio, count) VALUES (20.87, 77.09, 1);
INSERT INTO layout_items (weight, ratio, count) VALUES (75.97, 52.28, 59);
