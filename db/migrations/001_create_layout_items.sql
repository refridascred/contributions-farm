-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (active, ratio, weight) VALUES (45, 83.72, 8.69);
INSERT INTO layout_items (active, ratio, weight) VALUES (60, 81.66, 79.51);
INSERT INTO layout_items (active, ratio, weight) VALUES (70, 22.11, 49.74);
