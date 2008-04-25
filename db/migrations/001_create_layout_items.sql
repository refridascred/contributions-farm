-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, weight, count) VALUES (83.99, 53.94, 42);
INSERT INTO layout_items (ratio, weight, count) VALUES (12.4, 35.46, 46);
INSERT INTO layout_items (ratio, weight, count) VALUES (54.49, 15.67, 35);
