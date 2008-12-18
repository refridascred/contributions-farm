-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, active, ratio) VALUES (51.18, 95, 13.66);
INSERT INTO layout_items (weight, active, ratio) VALUES (83.92, 50, 52.86);
INSERT INTO layout_items (weight, active, ratio) VALUES (73.37, 66, 93.61);
