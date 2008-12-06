-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, count, ratio) VALUES (10.34, 32, 41.6);
INSERT INTO layout_items (weight, count, ratio) VALUES (83.89, 4, 49.72);
INSERT INTO layout_items (weight, count, ratio) VALUES (87.41, 69, 72.94);
