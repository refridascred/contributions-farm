-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (region, ratio, weight) VALUES ('cached', 84.6, 25.35);
INSERT INTO layout_items (region, ratio, weight) VALUES ('green', 56.37, 32.47);
INSERT INTO layout_items (region, ratio, weight) VALUES ('cached', 71.27, 6.33);
