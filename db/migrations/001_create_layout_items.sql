-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, level, weight) VALUES (0.35, 3, 79.27);
INSERT INTO layout_items (ratio, level, weight) VALUES (47.65, 25, 35.17);
